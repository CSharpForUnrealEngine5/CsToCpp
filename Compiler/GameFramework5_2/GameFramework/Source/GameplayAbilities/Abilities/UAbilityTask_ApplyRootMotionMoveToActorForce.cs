#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_ApplyRootMotionMoveToActorForce.h")]
///<summary>Applies force to character's movement</summary>
public partial class UAbilityTask_ApplyRootMotionMoveToActorForce : UAbilityTask_ApplyRootMotion_Base {
// AbilityTask_ApplyRootMotionMoveToActorForce
	public FApplyRootMotionMoveToActorForceDelegate OnFinished;
	public UObject ApplyRootMotionMoveToActorForce(UObject OwningAbility,string TaskInstanceName,UObject TargetActor,FVector TargetLocationOffset,ERootMotionMoveToActorTargetOffsetType OffsetAlignment,float Duration,UObject TargetLerpSpeedHorizontal,UObject TargetLerpSpeedVertical,bool bSetNewMovementMode,EMovementMode MovementMode,bool bRestrictSpeedToExpected,UObject PathOffsetCurve,UObject TimeMappingCurve,ERootMotionFinishVelocityMode VelocityOnFinishMode,FVector SetVelocityOnFinish,float ClampVelocityOnFinish,bool bDisableDestinationReachedInterrupt) { return default; }
	public UObject ApplyRootMotionMoveToTargetDataActorForce(UObject OwningAbility,string TaskInstanceName,FGameplayAbilityTargetDataHandle TargetDataHandle,int TargetDataIndex,int TargetActorIndex,FVector TargetLocationOffset,ERootMotionMoveToActorTargetOffsetType OffsetAlignment,float Duration,UObject TargetLerpSpeedHorizontal,UObject TargetLerpSpeedVertical,bool bSetNewMovementMode,EMovementMode MovementMode,bool bRestrictSpeedToExpected,UObject PathOffsetCurve,UObject TimeMappingCurve,ERootMotionFinishVelocityMode VelocityOnFinishMode,FVector SetVelocityOnFinish,float ClampVelocityOnFinish,bool bDisableDestinationReachedInterrupt) { return default; }
	public void OnTargetActorSwapped(UObject OriginalTarget,UObject NewTarget) {}
	public void OnRep_TargetLocation() {}
	public FVector StartLocation;
	public FVector TargetLocation;
	public AActor TargetActor;
	public FVector TargetLocationOffset;
	public ERootMotionMoveToActorTargetOffsetType OffsetAlignment;
	public float Duration;
	public bool bDisableDestinationReachedInterrupt;
	public bool bSetNewMovementMode;
	public byte NewMovementMode;
	public bool bRestrictSpeedToExpected;
	public UCurveVector PathOffsetCurve;
	public UCurveFloat TimeMappingCurve;
	public UCurveFloat TargetLerpSpeedHorizontalCurve;
	public UCurveFloat TargetLerpSpeedVerticalCurve;
}
