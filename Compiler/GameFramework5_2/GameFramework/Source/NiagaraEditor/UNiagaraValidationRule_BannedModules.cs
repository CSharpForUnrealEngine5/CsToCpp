#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraValidationRules.h")]
///<summary>This validation rule can ban the use of certain modules on all or a subset of platforms.</summary>
public partial class UNiagaraValidationRule_BannedModules : UNiagaraValidationRule {
// NiagaraValidationRule_BannedModules
	public FNiagaraPlatformSet Platforms;
	public TArray<UNiagaraScript> BannedModules;
}
