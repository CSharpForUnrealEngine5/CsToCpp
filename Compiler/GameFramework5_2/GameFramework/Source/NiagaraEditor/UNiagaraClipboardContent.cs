#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraClipboard.h")]
public partial class UNiagaraClipboardContent : UObject {
// NiagaraClipboardContent
	public TArray<UNiagaraClipboardFunction> Functions;
	public TArray<UNiagaraClipboardFunctionInput> FunctionInputs;
	public TArray<UNiagaraRendererProperties> Renderers;
	public TArray<UNiagaraScript> Scripts;
	public TArray<FNiagaraClipboardScriptVariable> ScriptVariables;
	public string ExportedNodes;
	public bool bFixupPasteIndexForScriptDependenciesInStack;
}
