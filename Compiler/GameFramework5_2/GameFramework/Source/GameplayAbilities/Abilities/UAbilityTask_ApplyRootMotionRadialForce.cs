namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Applies force to character&#39;s movement</summary>
[CppInclude("Abilities/Tasks/AbilityTask_ApplyRootMotionRadialForce.h")]
public partial class UAbilityTask_ApplyRootMotionRadialForce : UAbilityTask_ApplyRootMotion_Base {
	public static UClass StaticClass() {return default;}
	///<summary>OnFinish</summary>
	public FApplyRootMotionRadialForceDelegate OnFinish;
	///<summary>Apply force to character&#39;s movement</summary>
	public static UAbilityTask_ApplyRootMotionRadialForce ApplyRootMotionRadialForce(UGameplayAbility OwningAbility,FName TaskInstanceName,FVector Location,AActor LocationActor,float Strength,float Duration,float Radius,bool bIsPush,bool bIsAdditive,bool bNoZForce,UCurveFloat StrengthDistanceFalloff,UCurveFloat StrengthOverTime,bool bUseFixedWorldDirection,FRotator FixedWorldDirection,ERootMotionFinishVelocityMode VelocityOnFinishMode,FVector SetVelocityOnFinish,float ClampVelocityOnFinish) { return default; }
	///<summary>Location</summary>
	public FVector Location;
	///<summary>LocationActor</summary>
	public AActor LocationActor;
	///<summary>Strength</summary>
	public float Strength;
	///<summary>Duration</summary>
	public float Duration;
	///<summary>Radius</summary>
	public float Radius;
	///<summary>bIsPush</summary>
	public bool bIsPush;
	///<summary>bIsAdditive</summary>
	public bool bIsAdditive;
	///<summary>bNoZForce</summary>
	public bool bNoZForce;
	///<summary>Strength of the force over distance to Location</summary>
	public UCurveFloat StrengthDistanceFalloff;
	///<summary>Strength of the force over time</summary>
	public UCurveFloat StrengthOverTime;
	///<summary>bUseFixedWorldDirection</summary>
	public bool bUseFixedWorldDirection;
	///<summary>FixedWorldDirection</summary>
	public FRotator FixedWorldDirection;
}
