#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This validation rule can ban the use of certain modules on all or a subset of platforms.</summary>
[CppInclude("NiagaraValidationRules.h")]
public partial class UNiagaraValidationRule_BannedModules : UNiagaraValidationRule {
	public static UClass StaticClass() {return default;}
	///<summary>Platforms this validation rule will apply to.</summary>
	public FNiagaraPlatformSet Platforms;
	///<summary>BannedModules</summary>
	public TArray<UNiagaraScript> BannedModules;
}
