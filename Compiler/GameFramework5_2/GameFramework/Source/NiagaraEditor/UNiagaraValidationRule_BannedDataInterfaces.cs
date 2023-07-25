#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraValidationRules.h")]
///<summary>This validation rule can ban the use of certain datainterfaces on all or a subset of platforms.</summary>
public partial class UNiagaraValidationRule_BannedDataInterfaces : UNiagaraValidationRule {
// NiagaraValidationRule_BannedDataInterfaces
	public ENiagaraValidationSeverity Severity;
	public bool bBanOnGpu;
	public bool bBanOnCpu;
	public FNiagaraPlatformSet Platforms;
	public TArray<UClass> BannedDataInterfaces;
}
