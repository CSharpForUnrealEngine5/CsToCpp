namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class defines a node to wait on a gameplay tag query.</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayTagQuery.h")]
public partial class UAbilityTask_WaitGameplayTagQuery : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>Wait until the given gameplay tag query has become true or false, based on TriggerCondition.</summary>
	public static UAbilityTask_WaitGameplayTagQuery WaitGameplayTagQuery(UGameplayAbility OwningAbility,FGameplayTagQuery TagQuery,AActor InOptionalExternalTarget/*=nullptr*/,EWaitGameplayTagQueryTriggerCondition TriggerCondition/*=EWaitGameplayTagQueryTriggerCondition.WhenTrue*/,bool bOnlyTriggerOnce/*=false*/) { return default; }
	///<summary>This will update the tags in the TargetTags container to reflect that tags that are on the target ASC.</summary>
	public void UpdateTargetTags(FGameplayTag Tag,int NewCount) {}
	///<summary>This delegate will be triggered when the trigger condition has been met.</summary>
	public FWaitGameplayTagQueryDelegate Triggered;
	///<summary>This is the optional external target to use when getting the ASC to get tags from.</summary>
	public UAbilitySystemComponent OptionalExternalTarget;
}
