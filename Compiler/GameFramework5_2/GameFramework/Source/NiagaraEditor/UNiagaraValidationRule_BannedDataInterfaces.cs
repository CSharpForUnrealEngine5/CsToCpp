#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This validation rule can ban the use of certain datainterfaces on all or a subset of platforms.</summary>
[CppInclude("NiagaraValidationRules.h")]
public partial class UNiagaraValidationRule_BannedDataInterfaces : UNiagaraValidationRule {
	///<summary>Severity</summary>
	public ENiagaraValidationSeverity Severity;
	///<summary>bBanOnGpu</summary>
	public bool bBanOnGpu;
	///<summary>bBanOnCpu</summary>
	public bool bBanOnCpu;
	///<summary>Platforms</summary>
	public FNiagaraPlatformSet Platforms;
	///<summary>BannedDataInterfaces</summary>
	public TArray<UClass> BannedDataInterfaces;
}
