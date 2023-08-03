#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayEffectApplied_Target.h")]
public partial class UAbilityTask_WaitGameplayEffectApplied_Target : UAbilityTask_WaitGameplayEffectApplied {
	public static UClass StaticClass() {return default;}
	///<summary>OnApplied</summary>
	public FGameplayEffectAppliedTargetDelegate OnApplied;
	///<summary>Wait until the owner (or External Owner) applies a GameplayEffect to a Target (the target may be the owner too!). If TriggerOnce is true, this task will only return one time. Otherwise it will return everytime a GE is applied that meets the requirements over the life of the ability</summary>
	public static UAbilityTask_WaitGameplayEffectApplied_Target WaitGameplayEffectAppliedToTarget(UGameplayAbility OwningAbility,FGameplayTargetDataFilterHandle TargetFilter,FGameplayTagRequirements SourceTagRequirements,FGameplayTagRequirements TargetTagRequirements,bool TriggerOnce/*=false*/,AActor OptionalExternalOwner/*=nullptr*/,bool ListenForPeriodicEffects/*=false*/) { return default; }
	///<summary>Wait until the owner (or External Owner) applies a GameplayEffect to a Target (the target may be the owner too!). If TriggerOnce is true, this task will only return one time. Otherwise it will return everytime a GE is applied that meets the requirements over the life of the ability</summary>
	public static UAbilityTask_WaitGameplayEffectApplied_Target WaitGameplayEffectAppliedToTarget_Query(UGameplayAbility OwningAbility,FGameplayTargetDataFilterHandle SourceFilter,FGameplayTagQuery SourceTagQuery,FGameplayTagQuery TargetTagQuery,bool TriggerOnce/*=false*/,AActor OptionalExternalOwner/*=nullptr*/,bool ListenForPeriodicEffect/*=false*/) { return default; }
}
