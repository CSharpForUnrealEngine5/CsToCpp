namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This validation rule can ban the use of certain renderers on all or a subset of platforms.</summary>
[CppInclude("NiagaraValidationRules.h")]
public partial class UNiagaraValidationRule_BannedRenderers : UNiagaraValidationRule {
	public static UClass StaticClass() {return default;}
	///<summary>Platforms this validation rule will apply to.</summary>
	public FNiagaraPlatformSet Platforms;
	///<summary>BannedRenderers</summary>
	public TArray<UClass> BannedRenderers;
}
