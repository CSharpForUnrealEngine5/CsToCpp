#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_ApplyRootMotionConstantForce.h")]
///<summary>Applies force to character's movement</summary>
public partial class UAbilityTask_ApplyRootMotionConstantForce : UAbilityTask_ApplyRootMotion_Base {
// AbilityTask_ApplyRootMotionConstantForce
	public FApplyRootMotionConstantForceDelegate OnFinish;
	public static UAbilityTask_ApplyRootMotionConstantForce ApplyRootMotionConstantForce(UGameplayAbility OwningAbility,string TaskInstanceName,FVector WorldDirection,float Strength,float Duration,bool bIsAdditive,UCurveFloat StrengthOverTime,ERootMotionFinishVelocityMode VelocityOnFinishMode,FVector SetVelocityOnFinish,float ClampVelocityOnFinish,bool bEnableGravity) { return default; }
	public FVector WorldDirection;
	public float Strength;
	public float Duration;
	public bool bIsAdditive;
	public UCurveFloat StrengthOverTime;
	public bool bEnableGravity;
}
