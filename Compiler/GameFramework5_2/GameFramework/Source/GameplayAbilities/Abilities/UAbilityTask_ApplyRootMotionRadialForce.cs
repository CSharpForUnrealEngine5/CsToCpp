#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_ApplyRootMotionRadialForce.h")]
///<summary>Applies force to character's movement</summary>
public partial class UAbilityTask_ApplyRootMotionRadialForce : UAbilityTask_ApplyRootMotion_Base {
// AbilityTask_ApplyRootMotionRadialForce
	public FApplyRootMotionRadialForceDelegate OnFinish;
	public static UAbilityTask_ApplyRootMotionRadialForce ApplyRootMotionRadialForce(UGameplayAbility OwningAbility,string TaskInstanceName,FVector Location,AActor LocationActor,float Strength,float Duration,float Radius,bool bIsPush,bool bIsAdditive,bool bNoZForce,UCurveFloat StrengthDistanceFalloff,UCurveFloat StrengthOverTime,bool bUseFixedWorldDirection,FRotator FixedWorldDirection,ERootMotionFinishVelocityMode VelocityOnFinishMode,FVector SetVelocityOnFinish,float ClampVelocityOnFinish) { return default; }
	public FVector Location;
	public AActor LocationActor;
	public float Strength;
	public float Duration;
	public float Radius;
	public bool bIsPush;
	public bool bIsAdditive;
	public bool bNoZForce;
	public UCurveFloat StrengthDistanceFalloff;
	public UCurveFloat StrengthOverTime;
	public bool bUseFixedWorldDirection;
	public FRotator FixedWorldDirection;
}
