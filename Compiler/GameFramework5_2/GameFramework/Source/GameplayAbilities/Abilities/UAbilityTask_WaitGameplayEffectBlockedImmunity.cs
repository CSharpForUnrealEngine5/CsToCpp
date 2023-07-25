#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectBlockedImmunity.h")]
public partial class UAbilityTask_WaitGameplayEffectBlockedImmunity : UAbilityTask {
// AbilityTask_WaitGameplayEffectBlockedImmunity
	public FGameplayEffectBlockedDelegate Blocked;
	public UObject WaitGameplayEffectBlockedByImmunity(UObject OwningAbility,FGameplayTagRequirements SourceTagRequirements,FGameplayTagRequirements TargetTagRequirements,UObject OptionalExternalTarget/*=nullptr*/,bool OnlyTriggerOnce/*=false*/) { return default; }
	public UAbilitySystemComponent ExternalOwner;
}
