#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Validation rule to check that we don&#39;t have a tick dependency we don&#39;t want.</summary>
[CppInclude("NiagaraValidationRules.h")]
public partial class UNiagaraValidationRule_TickDependencyCheck : UNiagaraValidationRule {
	///<summary>How do we want to repro the error in the stack</summary>
	public ENiagaraValidationSeverity Severity;
	///<summary>Check that the actor component interface isn&#39;t adding a tick dependency on the CPU.</summary>
	public bool bCheckActorComponentInterface;
	///<summary>Check that the camera data interface isn&#39;t adding a tick dependency on the CPU.</summary>
	public bool bCheckCameraDataInterface;
	///<summary>Check that the skeletal mesh interface isn&#39;t adding a tick dependency on the CPU.</summary>
	public bool bCheckSkeletalMeshInterface;
}
