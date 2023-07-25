#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_ApplyRootMotion_Base.h")]
///<summary>Base class for ability tasks that apply root motion</summary>
public partial class UAbilityTask_ApplyRootMotion_Base : UAbilityTask {
// AbilityTask_ApplyRootMotion_Base
	public string ForceName;
	public ERootMotionFinishVelocityMode FinishVelocityMode;
	public FVector FinishSetVelocity;
	public float FinishClampVelocity;
	public UCharacterMovementComponent MovementComponent;
}
