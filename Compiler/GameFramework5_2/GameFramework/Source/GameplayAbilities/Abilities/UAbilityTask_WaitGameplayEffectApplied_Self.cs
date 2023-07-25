#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectApplied_Self.h")]
public partial class UAbilityTask_WaitGameplayEffectApplied_Self : UAbilityTask_WaitGameplayEffectApplied {
// AbilityTask_WaitGameplayEffectApplied_Self
	public FGameplayEffectAppliedSelfDelegate OnApplied;
	public UObject WaitGameplayEffectAppliedToSelf(UObject OwningAbility,FGameplayTargetDataFilterHandle SourceFilter,FGameplayTagRequirements SourceTagRequirements,FGameplayTagRequirements TargetTagRequirements,bool TriggerOnce/*=false*/,UObject OptionalExternalOwner/*=nullptr*/,bool ListenForPeriodicEffect/*=false*/) { return default; }
	public UObject WaitGameplayEffectAppliedToSelf_Query(UObject OwningAbility,FGameplayTargetDataFilterHandle SourceFilter,FGameplayTagQuery SourceTagQuery,FGameplayTagQuery TargetTagQuery,bool TriggerOnce/*=false*/,UObject OptionalExternalOwner/*=nullptr*/,bool ListenForPeriodicEffect/*=false*/) { return default; }
}
