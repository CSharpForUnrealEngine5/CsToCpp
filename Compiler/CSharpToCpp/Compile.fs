module rec Compile
open System
open System.Linq
open System.IO
open Microsoft.CodeAnalysis
open Microsoft.CodeAnalysis.CSharp
open Microsoft.CodeAnalysis.CSharp.Strict
open Microsoft.CodeAnalysis.CSharp.Syntax

type NotSupportedException (node : CSharpSyntaxNode, msg : string, writeToFile : string) = 
    inherit Exception(msg)
    member _.node = node
    member _.writeToFile = writeToFile

let writeClass name =
    let _h = h
    let gcp = Path.GetFullPath(generateCodePath)
    if not (Directory.Exists(generateCodePath)) then
        Directory.CreateDirectory(generateCodePath) |> ignore
    let hFileName = $"{generateCodePath}/{name}.h"
    let cppFileName = $"{generateCodePath}/{name}.cpp"
    File.WriteAllLines(cppFileName, cpp)
    h.Insert(0,$"#include \"{name}.generated.h\"")
    let inc = includes.Distinct().Reverse()
    inc |> Seq.iter (fun i -> h.Insert(0,$"#include \"{i}\""))
    h.Insert(0, "#pragma once")
    File.WriteAllLines(hFileName, h)
    includes.Clear()
    cpp.Clear()
    h.Clear()
    ()

let compileAll (trees : SyntaxTree[]) (models : SemanticModel[]) = 
    Array.iter2 (fun t m -> compile t m) trees models 
    ()


let compile t m =
    try
        let root = t.GetRoot()
        // dumpLog m root
        compileNode m root
    with
        | :? NotSupportedException as nse ->
            errorHandler nse
            if nse.writeToFile <> "" then
                writeClass nse.writeToFile
        | e ->
            eprintfn "%s" (e.ToString())

let errorHandler nse =
    let loc = nse.node.GetLocation()
    let line = loc.GetLineSpan().StartLinePosition.Line
    let message = $"{nse.Message}: {nse.node.Kind()} at line {line}"
    h.Add $"#error {message}"
    eprintfn "%s" message

let rec compileNode m node =
    let node = node :?> CSharpSyntaxNode
    match node  with
    | CompilationUnit (extrnList, usingList, attrList,memDeclList,_) -> 
        List.iter (compileNode m) memDeclList
    | NamespaceDeclaration (attrList,_,Identifier name,_,externAliasList,usingList,memDeclList,_,_) -> 
        List.iter (compileNode m) memDeclList
    | FileScopedNamespaceDeclaration (attrList,_,Identifier name,_,externAliasList,usingList,memDeclList) ->
        List.iter (compileNode m) memDeclList
    | ClassDeclaration (attrList,_,Token name,typeParamList,baseList,
        typeParamConstraintList,_,memDeclList,_,_) ->
        if typeParamList <> null then
            NotSupportedException(node, "Generic classes not supported", "") |> raise
        dumpLog name m node
        compileClassDeclaration m name baseList memDeclList attrList
    | DelegateDeclaration dd ->
        compileDelegate m dd
    | _ ->   NotSupportedException(node, "Unsuppprted node", "") |> raise


let compileClassDeclaration m name baseList memDeclList attrList =
    let name' = name.Substring(1)
    try 
        let bases = compileBaseList baseList
        generatedInclude <- name'
        let src = includes.Add $"CoreMinimal.h"
        includesFromAttr m attrList
        let _i1 = includes
        cpp.Add $"#include \"{name'}.h\""
        getBaseListIncludes m baseList
        let _i2 = includes
        //h.Add "UCLASS(BlueprintType)"
        h.Add "UCLASS(Blueprintable, BlueprintType, ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))"
        h.Add $"class {name} : public {bases} {{"
        h.Add "GENERATED_BODY()"
        h.Add "public:"
        let ms = compileMemDeclList m name memDeclList
        h.Add "};"
        writeClass name'
    with
        | :? NotSupportedException as nse ->
            NotSupportedException(nse.node, $"In class {name}: {nse.Message}", name') |> raise
    ()

let includesFromAttr m attrList =
    if attrList.IsEmpty |> not then
        let attrList = attrList.Head
        let f (a : AttributeSyntax) =
            if (a.Name.ToString().Contains("CppInclude")) then
                let args = a.ArgumentList
                let es = args.Arguments.Select 
                                (fun a -> compileExpressionText m a.Expression)
                let es = es.Select(fun (e : string) -> e.Replace("TEXT(\"","").Replace("\")",""))
                let es = es |> List.ofSeq
                includes.AddRange(es)
                let _i = includes
                ()
            ()
        attrList.Attributes |> Seq.iter f

let compileMemDeclList m pc memDeclList =
    memDeclList |> List.map (compileMemDecl m pc)

let compileMemDecl m pc memDecl =
    match memDecl with
    | FieldDeclaration (attrList,varDecl,_) -> 
        compileVarDecls m varDecl false
    | MethodDeclaration md -> 
        compileMethod m pc md
    | ConstructorDeclaration cd  ->
        compileConstructor m pc cd
    | DelegateDeclaration dd ->
        compileDelegate m dd
    | n -> NotSupportedException(n, "Member not supported", "") |> raise

let compileConstructor m pc (attrList,Token id,paramList,init,body,exprBody,_) =
    let pl = compileParameterList m paramList false
    cpp.Add $"{pc}::{id}({pl})"
    h.Add $"{id}({pl});"
    compileBlock m body

let compileDelegate m (arity,attrList,_,returnType,id,tyParams,
            paramList,_,_) =
    let (rty,_) = compileType m returnType
    let pl = compileParameterList m paramList true
    let pCount = paramList.ChildNodes().Count()
    if pCount = 1 then
        h.Add $"DECLARE_DYNAMIC_MULTICAST_DELEGATE_OneParam({id},{pl});"
    else 
        ()

let compileMethod m pc (arity,attrList,returnType,ei,
                        Token id,typeParamList,paramList,
                        constraintClauseList,block,arrowExpr,_) =
    let (rty,_) = compileType m returnType
    let pl = compileParameterList m paramList false
    let method = returnType.Parent
    let ds = m.GetDeclaredSymbol method
    let attrs = ds.GetAttributes()
    if hasAttr "CppNoUFunction" attrs |> not then
        h.Add "UFUNCTION(BlueprintCallable)"
    cpp.Add $"{rty} {pc}::{id}({pl})"
    h.Add $"virtual {rty} {id}({pl});"
    compileBlock m block

let compileBlock m block : unit=
    cpp.Add "{"
    let blockSrc =
        match block with
        | Block (attrList,_,stmtList,_) ->
            stmtList |> List.map (compileStatement m)
        | b -> NotSupportedException(b, "Statement not supported", "") |> raise
    cpp.Add "}"

let compileExpressionText m expr =
    let (e,_) = compileExpression m expr
    e

let rec compileStatement m stmt : unit =
    let h_ = h
    let cpp_ = cpp
    let includes_ = includes
    match stmt with
    | ReturnStatement (attrList,_,expr,_) -> 
        if expr = null then cpp.Add "return;"
        else cpp.Add $"return {compileExpressionText m expr};"
    | LocalDeclarationStatement (isConst, attrList,
            Token awaitKw, Token usingKw, decl, _) ->
        compileVariableDeclaration m decl
    | IfStatement (attrList,_,_,expr,_,stmt,elseClause) ->
        let e = compileExpressionText m expr
        cpp.Add $"if ({e})"
        let stmt = compileStatement m stmt
        if elseClause <> null then
            cpp.Add "else"
            compileStatement m elseClause.Statement
    | ExpressionStatement (b,attrList,e,_) ->
        cpp.Add $"{compileExpressionText m e};"
    | :? ForStatementSyntax as f->
        let (decl,_) = compileVarDeclsToString m f.Declaration
        let inits = f.Initializers |> Seq.cast<ExpressionSyntax> |> Seq.map (compileExpressionText m)
        let inits = String.Join(",", inits)
        let (cond,_) = compileExpression m f.Condition
        let incs = f.Incrementors |> Seq.cast<ExpressionSyntax> |> Seq.map (compileExpressionText m)
        let incs = String.Join(",", incs)
        cpp.Add $"for({decl};{cond};{incs})"
        compileStatement m f.Statement
        ()
    | :?BlockSyntax as b ->
        compileBlock m b
    | _ -> NotSupportedException(stmt, "Statement not supported", "") |> raise

let compileVariableDeclaration m decl : unit =
    let v = compileVarDecls m decl true
    ()
  
let compileVarDeclsToString m (varDecl : VariableDeclarationSyntax) =
    let vs = varDecl.ChildNodes()
    let tn = vs |> Seq.take 1 |> Seq.exactlyOne

    let vs = vs |> Seq.skip 1 |> Seq.cast<VariableDeclaratorSyntax>
    let isStatic = declIsStatic m vs
    let vs = vs |> Seq.map (compileVariableDeclarator m) 
                |> List.ofSeq
    let vs = String.Join(",", vs)

    let (ty,_) = compileType m tn
    let s = if isStatic then "static " else ""
    ($"{s} {ty} {vs}",isStatic)

let declIsStatic (m : SemanticModel) (vs : VariableDeclaratorSyntax seq) =
    let f = vs |> Seq.take 1 |> List.ofSeq |> List.exactlyOne
    let ds = m.GetDeclaredSymbol f
    ds.IsStatic

let compileVarDecls m varDecl isLocal =
    let h_ = h
    let cpp_ = cpp
    let includes_ = includes
    //TODO: Builtin types, enums, etc.
    let (str,isStatic) = compileVarDeclsToString m varDecl
    if isLocal then
        cpp.Add $"{str};"
    else
        //TODO: Add static definition to cpp file
        // type className::varName;
        if isStatic |> not then
            h.Add "UPROPERTY(BlueprintReadWrite,EditAnywhere)"
        h.Add $"{str};"

let compileVariableDeclarator m (vdecl : VariableDeclaratorSyntax) =
    let ds = m.GetDeclaredSymbol vdecl
    match vdecl with
    | VariableDeclarator (Token id,bracketdArgsList,eqValue) ->
        if eqValue = null then
            id
        else 
            let e = compileExpressionText m eqValue.Value
            $"{id}={e}"
    | _ -> NotSupportedException(vdecl, "Variable Declarator not supported", "") |> raise

let getSymbolName (sy : ISymbol) =
    if sy = null then "" else sy.Name

let compileExpression m expr : (string*(ITypeSymbol*ISymbol))=
    let ty = m.GetTypeInfo expr
    let ds = m.GetSymbolInfo expr
    let tOrS = (ty.Type,ds.Symbol)
    match expr with
    | ConditionalExpression (e1,_,e2,_,e3) ->
        let (e1',_) = compileExpression m e1
        let (e2',_) = compileExpression m e2
        let (e3',_) = compileExpression m e3
        ($"{e1'}?{e2'}:{e3'}",tOrS)
    | MemberAccessExpression (expr,_,id) ->
        let (l,(ety,esy)) = compileExpression m expr
        let (id,ity) = compileExpression m id
        let kind = if ety <> null then ety.TypeKind else TypeKind.Error
        let syKind = if esy <> null then esy.Kind else SymbolKind.ErrorType
        let op =
            match l,kind,syKind with
            | "this",_,_ -> "->"
            | "Super",_,_ -> "::"
            | _,TypeKind.Class,SymbolKind.NamedType -> 
                getIncludes ety |> includes.AddRange
                "::"
            | _,TypeKind.Struct,SymbolKind.NamedType -> "::"
            | _,TypeKind.Class,_ -> "->"
            | _,TypeKind.Enum,_ -> "::"
            | _,TypeKind.Struct,_ -> "."
            | _ -> assert false; ""
        ($"{l}{op}{id}",ity)
    | ParenthesizedExpression (_,e,_) ->
        let (e',ty') = compileExpression m e
        ($"({e'})",ty')
    | LiteralExpression (Token v) ->
        if v.Length > 1 && v[0] = '"' then
            ($"TEXT({v})",tOrS)
        else if v = "null" then
            ("nullptr",tOrS)
        else
            (v,tOrS)
    | IdentifierName (Token id) ->
        let id =
            if ds.Symbol <> null then
                let attrs = ds.Symbol.GetAttributes()
                //CppCode
                let code = attrs |> Seq.filter (fun a -> a.AttributeClass.Name.Contains("CppCode"))
                if Seq.isEmpty code |> not then
                    let code = Seq.exactlyOne code
                    let cargs = code.ConstructorArguments
                    id.Replace(cargs[0].Value.ToString(),cargs[1].Value.ToString())
                else
                    id
            else 
                id
        (id,tOrS)
    | GenericName (isUnbound,Token id,typeArgList) ->
        let f (ty : TypeSyntax) =
            let s = compileType m ty |> fst
            s.Replace("*","")
        let args = String.Join(",",
            typeArgList.Arguments |> Seq.map f)
        ($"{id}<{args}>",tOrS)
    | InvocationExpression (expr,argsList) ->
        let (ls,ty') = compileExpression m expr
        if ls.StartsWith("Code<") then
            let cppCode = argsList.Arguments.First()
            (cppCode.ToString().Replace("\"",""),ty')
        else
            let exList : string = compileArgsList m argsList
            ($"{ls}({exList})",tOrS)
    | BinaryExpression (l,Token o,r)
    | AssignmentExpression (l, Token o, r) ->
        let (l,lty) = compileExpression m l
        let (r,rty) = compileExpression m r
        ($"{l}{o}{r}",tOrS)
    | ThisExpression _ ->
        ("this",tOrS)
    | BaseExpression _ ->
        ("Super",tOrS)
    | PrefixUnaryExpression (Token op,expr) ->
        let (e,ety) = compileExpression m expr
        ($"{op}{e}",ety)
    | PostfixUnaryExpression (expr,Token op) ->
        let (e,ety) = compileExpression m expr
        ($"{e}{op}",ety)
    | ObjectCreationExpression (_,tyId,argsList,initExpr) ->
        let (ty',needsNew) = compileType m tyId
        let exList = compileArgsList m argsList
        let initExpr' = compileInitExpression m initExpr
        let e = $"{ty'}({exList}){initExpr'}"
        if needsNew then
            ($"new {e}",tOrS)
        else
            (e,tOrS)
    | ImplicitObjectCreationExpression (_,argsList,initExpr) ->
        let tyStr = ty.Type.ToString().Replace("GameFramework.","").Replace(".","::")
        let exList = compileArgsList m argsList
        let initExpr' = compileInitExpression m initExpr
        let e = $"{tyStr}({exList}){initExpr'}"
        (e,tOrS)
    | CastExpression (_,ty,_,expr) ->
        let (ty',needsNew) = compileType m ty
        let (e,ety) = compileExpression m expr
        let estr = $"({ty'})({e})"
        (estr,tOrS)
    | InterpolatedStringExpression (_,es,_) -> 
        compileInterpolatedStringExpression m tOrS es
    | ElementAccessExpression (expr, argsList) ->
        let (e,_) = compileExpression m expr
        let exList = compileBracketedArgsList m argsList
        ($"{e}[{exList}]",tOrS)        
    | e -> NotSupportedException(e, "Expression not supported", "") |> raise
  
let compileInitExpression m initExpr =
    if initExpr = null then
        ""
    else
        let exprs = initExpr.Expressions |> Seq.cast<ExpressionSyntax> |> Seq.map (compileExpression m)
                    |> Seq.map (fun (e,_) -> $".{e}")
        let exprs' = String.Join(",",exprs)
        $"{{{exprs'}}}"

let compileInterpolatedStringExpression m tOrS es =
    let ss = es |> List.map 
                (fun e -> 
                    match e with
                    | InterpolatedStringText (Token str) -> 
                        $"TEXT(\"{str}\")"
                    | Interpolation (_,e,a,f,_) ->
                        let (e',(ty,sy)) = compileExpression m e
                        match ty.Name.ToLower() with
                        | "int32" -> $"FString::FromInt({e'})"
                        | "single" -> $"FString::SanitizeFloat({e'})"
                        | "double" -> $"FString::SanitizeFloat({e'})"
                        | "string" -> e'
                        | _ -> NotSupportedException(e, $"Interpolated string {e'}", "") |> raise
                    | _ -> NotSupportedException(e, "Interpolated string", "") |> raise
                ) 
    let ss' = String.Join("+",ss)
    (ss',tOrS)

let compileArgsList m argsList =
    let f (a : ArgumentSyntax) =
        let (e,_) = compileExpression m a.Expression
        e
    let a = argsList.Arguments |> Seq.map f
    String.Join(",",a)

let compileBracketedArgsList m (argsList : BracketedArgumentListSyntax)=
    let f (a : ArgumentSyntax) =
        let (e,_) = compileExpression m a.Expression
        e
    let a = argsList.Arguments |> Seq.map f
    String.Join(",",a)

let hasAttr (attr : string) (attrs : AttributeData seq) =
    attrs |> Seq.filter (fun a -> a.AttributeClass.Name.Contains attr)
        |> Seq.isEmpty |> not

let compileParameterList m paramList forDelegate =
    let pc = paramList.ChildNodes()
    let f1 (p : ParameterSyntax) =
        match p with
        | Parameter (attrList,ty,Token id, def) ->
            if def <> null then
                NotSupportedException(p, "parameter defaults", "") |> raise
            let (ts,_) = compileType m ty
            let dsPar = m.GetDeclaredSymbol ty.Parent
            let attrsPar = dsPar.GetAttributes()
            let hasConstRef = hasAttr "CppConstRef" attrsPar
            let ty'' = m.GetTypeInfo p
            let ds'' = m.GetDeclaredSymbol p
            let attrsDs = ds''.GetAttributes()
            //let tyAttrs = ty''.Type.GetAttributes()
            let hasPointer = hasAttr "CppPointer" attrsDs
            let hasCppInclude = hasAttr "CppInclude" attrsPar
            let hasEnumInNamespace = 
                let ty' = m.GetTypeInfo ty
                if ty'.Type <> null then
                    let attrs = ty'.Type.GetAttributes()
                    hasAttr "CppEnumInNamespace" attrs
                else
                    false
            match hasConstRef,hasEnumInNamespace,hasPointer,forDelegate with
            | false,false,false,true -> $"{ts},{id}"
            | false,false,false,false -> $"{ts} {id}"
            | true,_,_,_ -> $"const {ts}& {id}"
            | _,true,_,_ -> $"{ts}::Type {id}"
            | _,_,true,_ -> $"{ts}* {id}"
        | _ -> NotSupportedException(p, "Parameter not supported", "") |> raise

            
    let mutable addComma = false
    let f2 ps =
        let comma = if addComma then "," else ""
        addComma <- true
        $"{comma}{ps}"
    let d = pc |> Seq.cast<ParameterSyntax> 
                |> List.ofSeq 
                |> List.map f1
                |> List.map f2
    String.Join("",d)

let rec compileType (m : SemanticModel) (tn : SyntaxNode)
    : string*bool =
    match tn :?> CSharpSyntaxNode with
    | Identifier id ->
        let t = m.GetTypeInfo tn
        let _i = includes
        let t = t.Type
        if t = null || t.BaseType = null then 
            (id |> List.take 1 |> List.exactlyOne,false)
        else 
            match t.BaseType.ToString() with
            | "System.Enum" | "System.ValueType" 
            | "System.MulticastDelegate" ->
                (t.Name,false)
            | _ ->
                getIncludes t |> includes.AddRange
                if t.IsStatic then
                    ($"static {t.Name}*",true)
                else
                    ($"{t.Name}*",true)
    | PredefinedType t ->
        if t.Text = "string" then
            ("FString",false)
        else
            (t.Text,false)
    | QualifiedName (Identifier name, _, qn)->
        let (qn',(ty,sy)) = compileExpression m qn
        ($"{name[0]}::{qn'}",false)
    | GenericName (b,Token id,typeArgList) ->
        let f (ty : TypeSyntax) =
            let s = compileType m ty |> fst
            //TODO: Add attribute for cases where we want the type and not the pointer
            s //s.Replace("*","")
        let args = String.Join(",",
            typeArgList.Arguments |> Seq.map f)
        ($"{id}<{args}>",false)
    | NullableType (ty,_) ->
        compileType m ty
    | n -> NotSupportedException(n, "Type not supported", "") |> raise

let getIncludes t : string list =
    let f2 (t : ITypeSymbol) =
        let attrs = t.GetAttributes()
        let f (a : AttributeData) =
            a.AttributeClass.Name.Contains("CppInclude")

        match Seq.isEmpty attrs with
        | false ->
            Some (Seq.filter f attrs)
        | _ ->
            None
    let f3 (a' : AttributeData seq option) =
        match a' with
        | Some a'' ->
            a'' |> Seq.map (fun a ->
                a.ConstructorArguments 
                    |> Seq.map (fun ca -> ca.Values) |> Seq.concat
                    |> Seq.map (fun tc -> tc.Value.ToString())
            )
        | None -> Seq.empty

    f2 t |> f3 |> Seq.concat |> List.ofSeq


let compileBaseList baseList =
    let children = baseList.ChildNodes()
    if children.Count() = 0 then
        NotSupportedException(baseList.Parent :?> CSharpSyntaxNode, "No parent class", "") |> raise
    let bases = children |> Seq.map (fun c -> c.ToString().Trim())
    String.Join(",", bases)
    
let getBaseListIncludes m baseList =
    let children = baseList.ChildNodes()
    let f1 (n : SyntaxNode) =
        let bt = n :?> SimpleBaseTypeSyntax
        let t = m.GetTypeInfo bt.Type
        assert (t.Type <> null)
        t.Type
    children |> 
        Seq.map f1 |> Seq.map getIncludes |> Seq.concat
        |> includes.AddRange
   
