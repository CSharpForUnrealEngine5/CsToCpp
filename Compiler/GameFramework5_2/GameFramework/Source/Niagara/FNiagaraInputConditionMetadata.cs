#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines options for conditionally editing and showing script inputs in the UI.</summary>
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraInputConditionMetadata {
	public string InputName;
	public TArray<string> TargetValues;
}
