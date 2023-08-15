namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines options for conditionally editing and showing script inputs in the UI.</summary>
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraInputConditionMetadata {
	public FName InputName;
	public TArray<string> TargetValues;
}
