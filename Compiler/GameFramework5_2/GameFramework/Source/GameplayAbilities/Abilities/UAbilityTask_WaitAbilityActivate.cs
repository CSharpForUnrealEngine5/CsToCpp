#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitAbilityActivate.h")]
///<summary>Waits for the actor to activate another ability</summary>
public partial class UAbilityTask_WaitAbilityActivate : UAbilityTask {
// AbilityTask_WaitAbilityActivate
	public FWaitAbilityActivateDelegate OnActivate;
	public  void OnAbilityActivate(UGameplayAbility ActivatedAbility) {}
	public static UAbilityTask_WaitAbilityActivate WaitForAbilityActivate(UGameplayAbility OwningAbility,FGameplayTag WithTag,FGameplayTag WithoutTag,bool IncludeTriggeredAbilities/*=false*/,bool TriggerOnce/*=true*/) { return default; }
	public static UAbilityTask_WaitAbilityActivate WaitForAbilityActivateWithTagRequirements(UGameplayAbility OwningAbility,FGameplayTagRequirements TagRequirements,bool IncludeTriggeredAbilities/*=false*/,bool TriggerOnce/*=true*/) { return default; }
	public static UAbilityTask_WaitAbilityActivate WaitForAbilityActivate_Query(UGameplayAbility OwningAbility,FGameplayTagQuery Query,bool IncludeTriggeredAbilities/*=false*/,bool TriggerOnce/*=true*/) { return default; }
}
