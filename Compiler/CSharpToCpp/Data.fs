[<AutoOpen>]
module Includes
open System.Collections.Generic

let mutable gameName = "TopDown"
let mutable outputName = "Game.Generated"
let mutable sourceName = "Game"

let mutable generateCodePath  = @$"../../../../../{gameName}\Source\{gameName}\{outputName}\"
let mutable sourceCodePath  = @$"../../../../../{gameName}\Source\{gameName}\{sourceName}\"

let mutable generatedInclude = ""

let includes = List<string>()

let cpp = List<string>()
let h = List<string>()