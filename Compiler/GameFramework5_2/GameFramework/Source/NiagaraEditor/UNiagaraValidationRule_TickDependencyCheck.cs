#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraValidationRules.h")]
///<summary>Validation rule to check that we don't have a tick dependency we don't want.</summary>
public partial class UNiagaraValidationRule_TickDependencyCheck : UNiagaraValidationRule {
// NiagaraValidationRule_TickDependencyCheck
	public ENiagaraValidationSeverity Severity;
	public bool bCheckActorComponentInterface;
	public bool bCheckCameraDataInterface;
	public bool bCheckSkeletalMeshInterface;
}
