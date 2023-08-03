#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Applies force to character&#39;s movement</summary>
[CppInclude("Abilities/Tasks/AbilityTask_ApplyRootMotionJumpForce.h")]
public partial class UAbilityTask_ApplyRootMotionJumpForce : UAbilityTask_ApplyRootMotion_Base {
	public static UClass StaticClass() {return default;}
	///<summary>OnFinish</summary>
	public FApplyRootMotionJumpForceDelegate OnFinish;
	///<summary>OnLanded</summary>
	public FApplyRootMotionJumpForceDelegate OnLanded;
	///<summary>Finish</summary>
	public  void Finish() {}
	///<summary>OnLandedCallback</summary>
	public  void OnLandedCallback(FHitResult Hit) {}
	///<summary>Apply force to character&#39;s movement</summary>
	public static UAbilityTask_ApplyRootMotionJumpForce ApplyRootMotionJumpForce(UGameplayAbility OwningAbility,string TaskInstanceName,FRotator Rotation,float Distance,float Height,float Duration,float MinimumLandedTriggerTime,bool bFinishOnLanded,ERootMotionFinishVelocityMode VelocityOnFinishMode,FVector SetVelocityOnFinish,float ClampVelocityOnFinish,UCurveVector PathOffsetCurve,UCurveFloat TimeMappingCurve) { return default; }
	///<summary>Rotation</summary>
	public FRotator Rotation;
	///<summary>Distance</summary>
	public float Distance;
	///<summary>Height</summary>
	public float Height;
	///<summary>Duration</summary>
	public float Duration;
	///<summary>MinimumLandedTriggerTime</summary>
	public float MinimumLandedTriggerTime;
	///<summary>bFinishOnLanded</summary>
	public bool bFinishOnLanded;
	///<summary>PathOffsetCurve</summary>
	public UCurveVector PathOffsetCurve;
	///<summary>Maps real time to movement fraction curve to affect the speed of the</summary>
	public UCurveFloat TimeMappingCurve;
}
