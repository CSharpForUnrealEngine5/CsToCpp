#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraClipboard.h")]
public partial class UNiagaraClipboardFunction : UObject {
// NiagaraClipboardFunction
	public void FOnPastedFunctionCallNode(UObject PastedFunctionCall) {}
	public string FunctionName;
	public string DisplayName;
	public ENiagaraClipboardFunctionScriptMode ScriptMode;
	public TSoftObjectPtr<UNiagaraScript> Script;
	public TArray<FNiagaraVariable> AssignmentTargets;
	public TArray<string> AssignmentDefaults;
	public TArray<UNiagaraClipboardFunctionInput> Inputs;
	public FOnPastedFunctionCallNode OnPastedFunctionCallNodeDelegate;
	public FGuid ScriptVersion;
	public TArray<FNiagaraStackMessage> Messages;
}
