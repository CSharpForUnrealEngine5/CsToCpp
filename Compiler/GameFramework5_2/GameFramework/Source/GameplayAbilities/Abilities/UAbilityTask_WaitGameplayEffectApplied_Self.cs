#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectApplied_Self.h")]
public partial class UAbilityTask_WaitGameplayEffectApplied_Self : UAbilityTask_WaitGameplayEffectApplied {
// AbilityTask_WaitGameplayEffectApplied_Self
	public FGameplayEffectAppliedSelfDelegate OnApplied;
	public static UAbilityTask_WaitGameplayEffectApplied_Self WaitGameplayEffectAppliedToSelf(UGameplayAbility OwningAbility,FGameplayTargetDataFilterHandle SourceFilter,FGameplayTagRequirements SourceTagRequirements,FGameplayTagRequirements TargetTagRequirements,bool TriggerOnce/*=false*/,AActor OptionalExternalOwner/*=nullptr*/,bool ListenForPeriodicEffect/*=false*/) { return default; }
	public static UAbilityTask_WaitGameplayEffectApplied_Self WaitGameplayEffectAppliedToSelf_Query(UGameplayAbility OwningAbility,FGameplayTargetDataFilterHandle SourceFilter,FGameplayTagQuery SourceTagQuery,FGameplayTagQuery TargetTagQuery,bool TriggerOnce/*=false*/,AActor OptionalExternalOwner/*=nullptr*/,bool ListenForPeriodicEffect/*=false*/) { return default; }
}
