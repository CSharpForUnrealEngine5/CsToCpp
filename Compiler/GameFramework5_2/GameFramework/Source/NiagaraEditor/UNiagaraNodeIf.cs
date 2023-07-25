#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeIf.h")]
public partial class UNiagaraNodeIf : UNiagaraNodeWithDynamicPins {
// NiagaraNodeIf
	public TArray<FNiagaraVariable> OutputVars;
	public TArray<FPinGuidsForPath> PathAssociatedPinGuids;
	public FGuid ConditionPinGuid;
}
