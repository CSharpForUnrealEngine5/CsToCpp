open System.IO
open System.Reflection
open System.Text
open System.Linq
open Microsoft.CodeAnalysis
open Microsoft.CodeAnalysis.CSharp
open Microsoft.CodeAnalysis.CSharp.Strict

open Compile

let compileProject (p : string) =
    generateCodePath <- Path.Combine(p,"../Game.Generated")
    let gcp = generateCodePath
    printfn "Code Path: %s" gcp
    // Force load of Gameframework
    GameFramework.GameFrameworkLoader.Load()

    let getAssembly (name : string) =
        let assemblyName = Assembly.GetExecutingAssembly().GetReferencedAssemblies()
                            .Where(fun assemblyName -> assemblyName.Name = name)
                            .First();
        Assembly.Load(assemblyName);

    let runtime = getAssembly "System.Runtime"
    let gameFramework = getAssembly "GameFramework"
    let trees =
       Directory.GetFiles(p,"*.cs") |> Seq.map
            (fun file ->
                let source = File.ReadAllText file
                let tree = 
                    CSharpSyntaxTree.ParseText(source
                        , CSharpParseOptions.Default,file)
                let root = tree.GetRoot()
                let diags = tree.GetDiagnostics root
                tree)
    let trees' = trees.ToArray()
    let compilation = CSharpCompilation.Create(Path.GetFileName p)
                        .AddSyntaxTrees(trees')
                        .AddReferences(
                                MetadataReference.CreateFromFile(
                                    typeof<System.Object>.Assembly.Location),
                                MetadataReference.CreateFromFile(runtime.Location),
                                MetadataReference.CreateFromFile(gameFramework.Location))
    let models = trees' |> Seq.map (fun t -> compilation.GetSemanticModel(t,false))
    let models' = models.ToArray()
    
    compileAll trees' models'
    ()

[<EntryPoint>]
let main argv =
    if argv.Length = 0 then
        eprintfn "CSharpToCpp Path-To-CSharp-Project"
        -1
    else if Directory.Exists argv[0] then
        printfn "Compiling %s" argv[0]
        compileProject argv[0]
        0    
    else
        eprintfn "Project file not found: %s" argv[0]
        -1

    
