namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraClipboard.h")]
public partial class UNiagaraClipboardContent : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Functions</summary>
	public TArray<UNiagaraClipboardFunction> Functions;
	///<summary>FunctionInputs</summary>
	public TArray<UNiagaraClipboardFunctionInput> FunctionInputs;
	///<summary>Renderers</summary>
	public TArray<UNiagaraRendererProperties> Renderers;
	///<summary>Scripts</summary>
	public TArray<UNiagaraScript> Scripts;
	///<summary>ScriptVariables</summary>
	public TArray<FNiagaraClipboardScriptVariable> ScriptVariables;
	///<summary>We expect nodes to be exported into this string using FEdGraphUtilities::ExportNodesToText</summary>
	public string ExportedNodes;
	///<summary>Markup MetaData to specify that if scripts are pasted from the clipboard to automatically fixup their order in the stack to satisfy dependencies.</summary>
	public bool bFixupPasteIndexForScriptDependenciesInStack;
}
