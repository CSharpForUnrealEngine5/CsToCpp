#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Waits for the actor to activate another ability</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectStackChange.h")]
public partial class UAbilityTask_WaitGameplayEffectStackChange : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnChange</summary>
	public FWaitGameplayEffectStackChangeDelegate OnChange;
	///<summary>InvalidHandle</summary>
	public FWaitGameplayEffectStackChangeDelegate InvalidHandle;
	///<summary>OnGameplayEffectStackChange</summary>
	public  void OnGameplayEffectStackChange(FActiveGameplayEffectHandle Handle,int NewCount,int OldCount) {}
	///<summary>Wait until the specified gameplay effect is removed.</summary>
	public static UAbilityTask_WaitGameplayEffectStackChange WaitForGameplayEffectStackChange(UGameplayAbility OwningAbility,FActiveGameplayEffectHandle Handle) { return default; }
}
