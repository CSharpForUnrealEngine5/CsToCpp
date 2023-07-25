#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraValidationRules.h")]
///<summary>This validation rule can ban the use of certain renderers on all or a subset of platforms.</summary>
public partial class UNiagaraValidationRule_BannedRenderers : UNiagaraValidationRule {
// NiagaraValidationRule_BannedRenderers
	public FNiagaraPlatformSet Platforms;
	public TArray<UClass> BannedRenderers;
}
