#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectApplied_Target.h")]
public partial class UAbilityTask_WaitGameplayEffectApplied_Target : UAbilityTask_WaitGameplayEffectApplied {
// AbilityTask_WaitGameplayEffectApplied_Target
	public FGameplayEffectAppliedTargetDelegate OnApplied;
	public static UAbilityTask_WaitGameplayEffectApplied_Target WaitGameplayEffectAppliedToTarget(UGameplayAbility OwningAbility,FGameplayTargetDataFilterHandle TargetFilter,FGameplayTagRequirements SourceTagRequirements,FGameplayTagRequirements TargetTagRequirements,bool TriggerOnce/*=false*/,AActor OptionalExternalOwner/*=nullptr*/,bool ListenForPeriodicEffects/*=false*/) { return default; }
	public static UAbilityTask_WaitGameplayEffectApplied_Target WaitGameplayEffectAppliedToTarget_Query(UGameplayAbility OwningAbility,FGameplayTargetDataFilterHandle SourceFilter,FGameplayTagQuery SourceTagQuery,FGameplayTagQuery TargetTagQuery,bool TriggerOnce/*=false*/,AActor OptionalExternalOwner/*=nullptr*/,bool ListenForPeriodicEffect/*=false*/) { return default; }
}
