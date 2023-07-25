#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectRemoved.h")]
///<summary>Waits for the actor to activate another ability</summary>
public partial class UAbilityTask_WaitGameplayEffectRemoved : UAbilityTask {
// AbilityTask_WaitGameplayEffectRemoved
	public FWaitGameplayEffectRemovedDelegate OnRemoved;
	public FWaitGameplayEffectRemovedDelegate InvalidHandle;
	public void OnGameplayEffectRemoved(FGameplayEffectRemovalInfo InGameplayEffectRemovalInfo) {}
	public UObject WaitForGameplayEffectRemoved(UObject OwningAbility,FActiveGameplayEffectHandle Handle) { return default; }
}
