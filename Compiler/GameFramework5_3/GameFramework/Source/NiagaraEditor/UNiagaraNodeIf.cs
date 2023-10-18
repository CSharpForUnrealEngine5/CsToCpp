namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeIf.h")]
public partial class UNiagaraNodeIf : UNiagaraNodeWithDynamicPins {
	public static UClass StaticClass() {return default;}
	///<summary>Outputs of this branch.</summary>
	public TArray<FNiagaraVariable> OutputVars;
	///<summary>PathAssociatedPinGuids</summary>
	public TArray<FPinGuidsForPath> PathAssociatedPinGuids;
	///<summary>ConditionPinGuid</summary>
	public FGuid ConditionPinGuid;
}
