#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeFunctionCall.h")]
public partial class UNiagaraNodeFunctionCall : UNiagaraNodeWithDynamicPins {
// NiagaraNodeFunctionCall
	public UNiagaraScript FunctionScript;
	public FGuid SelectedScriptVersion;
	public string FunctionScriptAssetObjectPath;
	public FNiagaraFunctionSignature Signature;
	public TMap<string,string> FunctionSpecifiers;
	public TArray<FNiagaraPropagatedVariable> PropagatedStaticSwitchParameters;
	public FGuid PreviousScriptVersion;
	public string PythonUpgradeScriptWarnings;
	public ENiagaraFunctionDebugState DebugState;
	public bool bInheritDebugStatus;
	public FGuid CachedChangeId;
	public FGuid InvalidScriptVersionReference;
	public string FunctionDisplayName;
	public TMap<FGuid,UNiagaraMessageData> MessageKeyToMessageMap;
	public TArray<FNiagaraStackMessage> StackMessages;
	public TMap<FGuid,string> BoundPinNames;
}
