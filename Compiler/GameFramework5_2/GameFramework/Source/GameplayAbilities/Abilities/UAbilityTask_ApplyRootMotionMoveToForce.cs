namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Applies force to character&#39;s movement</summary>
[CppInclude("Abilities/Tasks/AbilityTask_ApplyRootMotionMoveToForce.h")]
public partial class UAbilityTask_ApplyRootMotionMoveToForce : UAbilityTask_ApplyRootMotion_Base {
	public static UClass StaticClass() {return default;}
	///<summary>OnTimedOut</summary>
	public FApplyRootMotionMoveToForceDelegate OnTimedOut;
	///<summary>OnTimedOutAndDestinationReached</summary>
	public FApplyRootMotionMoveToForceDelegate OnTimedOutAndDestinationReached;
	///<summary>Apply force to character&#39;s movement</summary>
	public static UAbilityTask_ApplyRootMotionMoveToForce ApplyRootMotionMoveToForce(UGameplayAbility OwningAbility,string TaskInstanceName,FVector TargetLocation,float Duration,bool bSetNewMovementMode,EMovementMode MovementMode,bool bRestrictSpeedToExpected,UCurveVector PathOffsetCurve,ERootMotionFinishVelocityMode VelocityOnFinishMode,FVector SetVelocityOnFinish,float ClampVelocityOnFinish) { return default; }
	///<summary>StartLocation</summary>
	public FVector StartLocation;
	///<summary>TargetLocation</summary>
	public FVector TargetLocation;
	///<summary>Duration</summary>
	public float Duration;
	///<summary>bSetNewMovementMode</summary>
	public bool bSetNewMovementMode;
	///<summary>NewMovementMode</summary>
	public EMovementMode NewMovementMode;
	///<summary>If enabled, we limit velocity to the initial expected velocity to go distance to the target over Duration.</summary>
	public bool bRestrictSpeedToExpected;
	///<summary>PathOffsetCurve</summary>
	public UCurveVector PathOffsetCurve;
}
