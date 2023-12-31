namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitVelocityChange.h")]
public partial class UAbilityTask_WaitVelocityChange : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>Delegate called when velocity requirements are met</summary>
	public FWaitVelocityChangeDelegate OnVelocityChage;
	///<summary>Wait for the actor&#39;s movement component velocity to be of minimum magnitude when projected along given direction</summary>
	public static UAbilityTask_WaitVelocityChange CreateWaitVelocityChange(UGameplayAbility OwningAbility,FVector Direction,float MinimumMagnitude) { return default; }
	///<summary>CachedMovementComponent</summary>
	public UMovementComponent CachedMovementComponent;
}
