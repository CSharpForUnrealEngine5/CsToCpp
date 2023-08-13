namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Waits for the actor to activate another ability</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectRemoved.h")]
public partial class UAbilityTask_WaitGameplayEffectRemoved : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnRemoved</summary>
	public FWaitGameplayEffectRemovedDelegate OnRemoved;
	///<summary>InvalidHandle</summary>
	public FWaitGameplayEffectRemovedDelegate InvalidHandle;
	///<summary>OnGameplayEffectRemoved</summary>
	public void OnGameplayEffectRemoved(FGameplayEffectRemovalInfo InGameplayEffectRemovalInfo) {}
	///<summary>Wait until the specified gameplay effect is removed.</summary>
	public static UAbilityTask_WaitGameplayEffectRemoved WaitForGameplayEffectRemoved(UGameplayAbility OwningAbility,FActiveGameplayEffectHandle Handle) { return default; }
}
