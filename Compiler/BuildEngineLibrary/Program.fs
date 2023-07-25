// For more information see https://aka.ms/fsharp-console-apps
open System.IO
open System.Text.RegularExpressions
open System.Linq

let mutable engineSource = @"C:\UnrealEngine\Engines\UE_5.2\Engine\Source\Runtime\Engine\"
let mutable enhancedInputSource = @"C:\UnrealEngine\Engines\UE_5.2\Engine\Plugins\EnhancedInput\Source\EnhancedInput\"
let mutable niagaraSource = @"C:\UnrealEngine\Engines\UE_5.2\Engine\Plugins\FX\Niagara\Source\Niagara\"
let mutable aiModuleSource = @"C:\UnrealEngine\Engines\UE_5.2\Engine\Source\Runtime\AIModule\"
let mutable gameFrameworkPath = @"C:\UnrealEngine\Dev\CSharpExamples\CSharp\GameFramework\AIModule"
let matchClass = @"UCLASS.*\s+class\s+(\w+_API\s+)?(\w+)\s*\w*\s*:\s*public\s+(\w+)" 
// @"UCLASS.*class\s+ENGINE_API\s+(\w+)\s+:\s+public\s+(\w+)"

let engineFiles = Directory.EnumerateFiles(engineSource,"*.h",SearchOption.AllDirectories)
let enhancedInputFiles = Directory.EnumerateFiles(enhancedInputSource,"*.h",SearchOption.AllDirectories)
let niagaraFiles = Directory.EnumerateFiles(niagaraSource,"*.h",SearchOption.AllDirectories)
let aiFiles = Directory.EnumerateFiles(aiModuleSource,"*.h",SearchOption.AllDirectories)
let fileList' = engineFiles.Concat enhancedInputFiles
let fileList = fileList'.Concat niagaraFiles
let cf (f : string) =
    let source = File.ReadAllText f
    let matches = Regex.Match(source,matchClass,RegexOptions.Multiline)
    let cppInclude = Regex.Split(f, @"(Internal)|(Private)|(Public)|(Classes)")
    let cppInclude = cppInclude.[2].Substring 1
    let cppInclude = cppInclude.Replace('\\','/')
    let cppPath = Path.Combine(gameFrameworkPath, cppInclude.Replace(".h",".cs"))
    if matches.Success && File.Exists cppPath |> not then
        let matchesList = System.Collections.Generic.List<Match>()
        let rec ff (m : Match) =
            if m.Success then
                matchesList.Add m
                m.NextMatch() |> ff
            else
                ()
        ff matches
        let makeCSFile (matches : Match) = 
            let className = matches.Groups[2].Value
            let parentClassName = matches.Groups[3].Value
            let csharpSource = $@"
    [CppInclude(""{cppInclude}"")]
    public class {className} : {parentClassName} {{
    }}
"
            csharpSource
        let classes = Seq.map makeCSFile matchesList
        let classList = System.String.Join("", classes)
        let csharpSource = $@"using CSharpToCpp.Utilities;

namespace GameFramework;
{classList}
"
        let cppPathDir = Path.GetDirectoryName cppPath
        if Directory.Exists cppPathDir |> not then
            Directory.CreateDirectory cppPathDir |> ignore
        File.WriteAllText(cppPath, csharpSource)
        ()
    ()
aiFiles |> Seq.iter cf
let x = 3