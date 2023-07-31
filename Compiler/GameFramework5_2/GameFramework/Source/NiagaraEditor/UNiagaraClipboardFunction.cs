#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraClipboard.h")]
public partial class UNiagaraClipboardFunction : UObject {
	///<summary>FOnPastedFunctionCallNode</summary>
	public  void FOnPastedFunctionCallNode(UNiagaraNodeFunctionCall PastedFunctionCall) {}
	///<summary>FunctionName</summary>
	public string FunctionName;
	///<summary>DisplayName</summary>
	public string DisplayName;
	///<summary>ScriptMode</summary>
	public ENiagaraClipboardFunctionScriptMode ScriptMode;
	///<summary>Script</summary>
	public TSoftObjectPtr<UNiagaraScript> Script;
	///<summary>AssignmentTargets</summary>
	public TArray<FNiagaraVariable> AssignmentTargets;
	///<summary>AssignmentDefaults</summary>
	public TArray<string> AssignmentDefaults;
	///<summary>Inputs</summary>
	public TArray<UNiagaraClipboardFunctionInput> Inputs;
	///<summary>OnPastedFunctionCallNodeDelegate</summary>
	public FOnPastedFunctionCallNode OnPastedFunctionCallNodeDelegate;
	///<summary>ScriptVersion</summary>
	public FGuid ScriptVersion;
	///<summary>Messages</summary>
	public TArray<FNiagaraStackMessage> Messages;
}
