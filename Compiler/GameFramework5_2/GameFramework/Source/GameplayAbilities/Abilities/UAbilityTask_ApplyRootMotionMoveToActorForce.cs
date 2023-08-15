namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Applies force to character&#39;s movement</summary>
[CppInclude("Abilities/Tasks/AbilityTask_ApplyRootMotionMoveToActorForce.h")]
public partial class UAbilityTask_ApplyRootMotionMoveToActorForce : UAbilityTask_ApplyRootMotion_Base {
	public static UClass StaticClass() {return default;}
	///<summary>OnFinished</summary>
	public FApplyRootMotionMoveToActorForceDelegate OnFinished;
	///<summary>Apply force to character&#39;s movement</summary>
	public static UAbilityTask_ApplyRootMotionMoveToActorForce ApplyRootMotionMoveToActorForce(UGameplayAbility OwningAbility,FName TaskInstanceName,AActor TargetActor,FVector TargetLocationOffset,ERootMotionMoveToActorTargetOffsetType OffsetAlignment,float Duration,UCurveFloat TargetLerpSpeedHorizontal,UCurveFloat TargetLerpSpeedVertical,bool bSetNewMovementMode,EMovementMode MovementMode,bool bRestrictSpeedToExpected,UCurveVector PathOffsetCurve,UCurveFloat TimeMappingCurve,ERootMotionFinishVelocityMode VelocityOnFinishMode,FVector SetVelocityOnFinish,float ClampVelocityOnFinish,bool bDisableDestinationReachedInterrupt) { return default; }
	///<summary>Apply force to character&#39;s movement using an index into targetData instead of using an actor directly.</summary>
	public static UAbilityTask_ApplyRootMotionMoveToActorForce ApplyRootMotionMoveToTargetDataActorForce(UGameplayAbility OwningAbility,FName TaskInstanceName,FGameplayAbilityTargetDataHandle TargetDataHandle,int TargetDataIndex,int TargetActorIndex,FVector TargetLocationOffset,ERootMotionMoveToActorTargetOffsetType OffsetAlignment,float Duration,UCurveFloat TargetLerpSpeedHorizontal,UCurveFloat TargetLerpSpeedVertical,bool bSetNewMovementMode,EMovementMode MovementMode,bool bRestrictSpeedToExpected,UCurveVector PathOffsetCurve,UCurveFloat TimeMappingCurve,ERootMotionFinishVelocityMode VelocityOnFinishMode,FVector SetVelocityOnFinish,float ClampVelocityOnFinish,bool bDisableDestinationReachedInterrupt) { return default; }
	///<summary>OnTargetActorSwapped</summary>
	public void OnTargetActorSwapped(AActor OriginalTarget,AActor NewTarget) {}
	///<summary>OnRep_TargetLocation</summary>
	public void OnRep_TargetLocation() {}
	///<summary>StartLocation</summary>
	public FVector StartLocation;
	///<summary>TargetLocation</summary>
	public FVector TargetLocation;
	///<summary>TargetActor</summary>
	public AActor TargetActor;
	///<summary>TargetLocationOffset</summary>
	public FVector TargetLocationOffset;
	///<summary>OffsetAlignment</summary>
	public ERootMotionMoveToActorTargetOffsetType OffsetAlignment;
	///<summary>Duration</summary>
	public float Duration;
	///<summary>By default, this force ends when the destination is reached. Using this parameter you can disable it so it will not</summary>
	public bool bDisableDestinationReachedInterrupt;
	///<summary>bSetNewMovementMode</summary>
	public bool bSetNewMovementMode;
	///<summary>NewMovementMode</summary>
	public EMovementMode NewMovementMode;
	///<summary>If enabled, we limit velocity to the initial expected velocity to go distance to the target over Duration.</summary>
	public bool bRestrictSpeedToExpected;
	///<summary>PathOffsetCurve</summary>
	public UCurveVector PathOffsetCurve;
	///<summary>Maps real time to movement fraction curve to affect the speed of the</summary>
	public UCurveFloat TimeMappingCurve;
	///<summary>TargetLerpSpeedHorizontalCurve</summary>
	public UCurveFloat TargetLerpSpeedHorizontalCurve;
	///<summary>TargetLerpSpeedVerticalCurve</summary>
	public UCurveFloat TargetLerpSpeedVerticalCurve;
}
