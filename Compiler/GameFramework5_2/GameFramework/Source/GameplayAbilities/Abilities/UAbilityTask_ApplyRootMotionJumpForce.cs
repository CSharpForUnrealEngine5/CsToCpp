#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_ApplyRootMotionJumpForce.h")]
///<summary>Applies force to character's movement</summary>
public partial class UAbilityTask_ApplyRootMotionJumpForce : UAbilityTask_ApplyRootMotion_Base {
// AbilityTask_ApplyRootMotionJumpForce
	public FApplyRootMotionJumpForceDelegate OnFinish;
	public FApplyRootMotionJumpForceDelegate OnLanded;
	public  void Finish() {}
	public  void OnLandedCallback(FHitResult Hit) {}
	public static UAbilityTask_ApplyRootMotionJumpForce ApplyRootMotionJumpForce(UGameplayAbility OwningAbility,string TaskInstanceName,FRotator Rotation,float Distance,float Height,float Duration,float MinimumLandedTriggerTime,bool bFinishOnLanded,ERootMotionFinishVelocityMode VelocityOnFinishMode,FVector SetVelocityOnFinish,float ClampVelocityOnFinish,UCurveVector PathOffsetCurve,UCurveFloat TimeMappingCurve) { return default; }
	public FRotator Rotation;
	public float Distance;
	public float Height;
	public float Duration;
	public float MinimumLandedTriggerTime;
	public bool bFinishOnLanded;
	public UCurveVector PathOffsetCurve;
	public UCurveFloat TimeMappingCurve;
}
