#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectStackChange.h")]
///<summary>Waits for the actor to activate another ability</summary>
public partial class UAbilityTask_WaitGameplayEffectStackChange : UAbilityTask {
// AbilityTask_WaitGameplayEffectStackChange
	public FWaitGameplayEffectStackChangeDelegate OnChange;
	public FWaitGameplayEffectStackChangeDelegate InvalidHandle;
	public  void OnGameplayEffectStackChange(FActiveGameplayEffectHandle Handle,int NewCount,int OldCount) {}
	public static UAbilityTask_WaitGameplayEffectStackChange WaitForGameplayEffectStackChange(UGameplayAbility OwningAbility,FActiveGameplayEffectHandle Handle) { return default; }
}
