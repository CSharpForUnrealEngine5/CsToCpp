#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitAbilityActivate.h")]
///<summary>Waits for the actor to activate another ability</summary>
public partial class UAbilityTask_WaitAbilityActivate : UAbilityTask {
// AbilityTask_WaitAbilityActivate
	public FWaitAbilityActivateDelegate OnActivate;
	public void OnAbilityActivate(UObject ActivatedAbility) {}
	public UObject WaitForAbilityActivate(UObject OwningAbility,FGameplayTag WithTag,FGameplayTag WithoutTag,bool IncludeTriggeredAbilities/*=false*/,bool TriggerOnce/*=true*/) { return default; }
	public UObject WaitForAbilityActivateWithTagRequirements(UObject OwningAbility,FGameplayTagRequirements TagRequirements,bool IncludeTriggeredAbilities/*=false*/,bool TriggerOnce/*=true*/) { return default; }
	public UObject WaitForAbilityActivate_Query(UObject OwningAbility,FGameplayTagQuery Query,bool IncludeTriggeredAbilities/*=false*/,bool TriggerOnce/*=true*/) { return default; }
}
