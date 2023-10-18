namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Applies force to character&#39;s movement</summary>
[CppInclude("Abilities/Tasks/AbilityTask_ApplyRootMotionConstantForce.h")]
public partial class UAbilityTask_ApplyRootMotionConstantForce : UAbilityTask_ApplyRootMotion_Base {
	public static UClass StaticClass() {return default;}
	///<summary>OnFinish</summary>
	public FApplyRootMotionConstantForceDelegate OnFinish;
	///<summary>Apply force to character&#39;s movement</summary>
	public static UAbilityTask_ApplyRootMotionConstantForce ApplyRootMotionConstantForce(UGameplayAbility OwningAbility,FName TaskInstanceName,FVector WorldDirection,float Strength,float Duration,bool bIsAdditive,UCurveFloat StrengthOverTime,ERootMotionFinishVelocityMode VelocityOnFinishMode,FVector SetVelocityOnFinish,float ClampVelocityOnFinish,bool bEnableGravity) { return default; }
	///<summary>WorldDirection</summary>
	public FVector WorldDirection;
	///<summary>Strength</summary>
	public float Strength;
	///<summary>Duration</summary>
	public float Duration;
	///<summary>bIsAdditive</summary>
	public bool bIsAdditive;
	///<summary>Strength of the force over time</summary>
	public UCurveFloat StrengthOverTime;
	///<summary>bEnableGravity</summary>
	public bool bEnableGravity;
}
