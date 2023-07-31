#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeIf.h")]
public partial class UNiagaraNodeIf : UNiagaraNodeWithDynamicPins {
	///<summary>Outputs of this branch.</summary>
	public TArray<FNiagaraVariable> OutputVars;
	///<summary>PathAssociatedPinGuids</summary>
	public TArray<FPinGuidsForPath> PathAssociatedPinGuids;
	///<summary>ConditionPinGuid</summary>
	public FGuid ConditionPinGuid;
}
