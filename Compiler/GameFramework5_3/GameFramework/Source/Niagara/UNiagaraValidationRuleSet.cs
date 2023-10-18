namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A set of reusable validation rules.</summary>
[CppInclude("NiagaraValidationRuleSet.h")]
public partial class UNiagaraValidationRuleSet : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ValidationRules</summary>
	public TArray<UNiagaraValidationRule> ValidationRules;
}
