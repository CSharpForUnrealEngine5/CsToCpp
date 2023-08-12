[<AutoOpen>]
module DumpLog

open System.Collections.Generic
open Microsoft.CodeAnalysis
open System.IO

let mutable logFileName = @"C:\UnrealEngine\Projects\Logs"

let dumpLog (name : string) (model : SemanticModel) (root : SyntaxNode) =
    let log = List<string>()
    let mutable indent = ""
    let rec dumpNode (node : SyntaxNode) =
        let ds = model.GetDeclaredSymbol node 
        let s = model.GetSymbolInfo node
        let t = model.GetTypeInfo node
        let t' = node.GetType().ToString().Replace("Microsoft.CodeAnalysis.CSharp.Syntax.","")
        let t'' = node.ToString().Substring(0, System.Math.Min(node.ToString().Length,10)).Replace("\n","\\n")
        let bt = if t.Type <> null && t.Type.BaseType <> null then t.Type.BaseType.ToString() else "null"
        let is = if t.Type <> null then t.Type.IsStatic.ToString() else "none"
        let note = $"{indent}|node: {t'} sym: '{s.Symbol}' isStatic:{is} decl: '{ds}' baseType:'{bt}' text: '{t''}'"
        log.Add(note)
        indent <- indent + "    "
        node.ChildNodes() |> Seq.toArray |> Array.iter (fun n -> dumpNode n)         
        indent <- indent.Substring(0, indent.Length - 4)
    dumpNode root
    System.IO.File.WriteAllLines($"{logFileName}\\{name}.txt", log)
    ()

