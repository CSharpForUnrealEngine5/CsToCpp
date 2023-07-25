#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayTagQuery.h")]
///<summary>This class defines a node to wait on a gameplay tag query.</summary>
public partial class UAbilityTask_WaitGameplayTagQuery : UAbilityTask {
// AbilityTask_WaitGameplayTagQuery
	public UObject WaitGameplayTagQuery(UObject OwningAbility,FGameplayTagQuery TagQuery,UObject InOptionalExternalTarget/*=nullptr*/,EWaitGameplayTagQueryTriggerCondition TriggerCondition/*=EWaitGameplayTagQueryTriggerCondition.WhenTrue*/,bool bOnlyTriggerOnce/*=false*/) { return default; }
	public void UpdateTargetTags(FGameplayTag Tag,int NewCount) {}
	public FWaitGameplayTagQueryDelegate Triggered;
	public UAbilitySystemComponent OptionalExternalTarget;
}
