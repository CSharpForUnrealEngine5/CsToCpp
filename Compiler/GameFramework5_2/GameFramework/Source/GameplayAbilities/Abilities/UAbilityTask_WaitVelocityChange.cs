#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitVelocityChange.h")]
public partial class UAbilityTask_WaitVelocityChange : UAbilityTask {
// AbilityTask_WaitVelocityChange
	public FWaitVelocityChangeDelegate OnVelocityChage;
	public UObject CreateWaitVelocityChange(UObject OwningAbility,FVector Direction,float MinimumMagnitude) { return default; }
	public UMovementComponent CachedMovementComponent;
}
