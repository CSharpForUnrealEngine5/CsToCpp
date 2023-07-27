#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectBlockedImmunity.h")]
public partial class UAbilityTask_WaitGameplayEffectBlockedImmunity : UAbilityTask {
// AbilityTask_WaitGameplayEffectBlockedImmunity
	public FGameplayEffectBlockedDelegate Blocked;
	public static UAbilityTask_WaitGameplayEffectBlockedImmunity WaitGameplayEffectBlockedByImmunity(UGameplayAbility OwningAbility,FGameplayTagRequirements SourceTagRequirements,FGameplayTagRequirements TargetTagRequirements,AActor OptionalExternalTarget/*=nullptr*/,bool OnlyTriggerOnce/*=false*/) { return default; }
	public UAbilitySystemComponent ExternalOwner;
}
