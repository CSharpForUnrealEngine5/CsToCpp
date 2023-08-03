#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for ability tasks that apply root motion</summary>
[CppInclude("Abilities/Tasks/AbilityTask_ApplyRootMotion_Base.h")]
public partial class UAbilityTask_ApplyRootMotion_Base : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>ForceName</summary>
	public string ForceName;
	///<summary>What to do with character&#39;s Velocity when root motion finishes</summary>
	public ERootMotionFinishVelocityMode FinishVelocityMode;
	///<summary>If FinishVelocityMode mode is &quot;SetVelocity&quot;, character velocity is set to this value when root motion finishes</summary>
	public FVector FinishSetVelocity;
	///<summary>If FinishVelocityMode mode is &quot;ClampVelocity&quot;, character velocity is clamped to this value when root motion finishes</summary>
	public float FinishClampVelocity;
	///<summary>MovementComponent</summary>
	public UCharacterMovementComponent MovementComponent;
}
