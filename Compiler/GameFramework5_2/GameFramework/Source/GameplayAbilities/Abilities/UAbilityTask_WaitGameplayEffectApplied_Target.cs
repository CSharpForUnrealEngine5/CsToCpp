#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectApplied_Target.h")]
public partial class UAbilityTask_WaitGameplayEffectApplied_Target : UAbilityTask_WaitGameplayEffectApplied {
// AbilityTask_WaitGameplayEffectApplied_Target
	public FGameplayEffectAppliedTargetDelegate OnApplied;
	public UObject WaitGameplayEffectAppliedToTarget(UObject OwningAbility,FGameplayTargetDataFilterHandle TargetFilter,FGameplayTagRequirements SourceTagRequirements,FGameplayTagRequirements TargetTagRequirements,bool TriggerOnce/*=false*/,UObject OptionalExternalOwner/*=nullptr*/,bool ListenForPeriodicEffects/*=false*/) { return default; }
	public UObject WaitGameplayEffectAppliedToTarget_Query(UObject OwningAbility,FGameplayTargetDataFilterHandle SourceFilter,FGameplayTagQuery SourceTagQuery,FGameplayTagQuery TargetTagQuery,bool TriggerOnce/*=false*/,UObject OptionalExternalOwner/*=nullptr*/,bool ListenForPeriodicEffect/*=false*/) { return default; }
}
