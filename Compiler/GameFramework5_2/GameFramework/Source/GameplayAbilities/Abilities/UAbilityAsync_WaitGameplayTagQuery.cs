#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class defines an async node to wait on a gameplay tag query.</summary>
[CppInclude("Abilities/Async/AbilityAsync_WaitGameplayTagQuery.h")]
public partial class UAbilityAsync_WaitGameplayTagQuery : UAbilityAsync {
	///<summary>This delegate will be triggered when the trigger condition has been met.</summary>
	public FAsyncWaitGameplayTagQueryDelegate Triggered;
	///<summary>Wait until the given gameplay tag query has become true or false, based on TriggerCondition, looking at the target actors ASC.</summary>
	public static UAbilityAsync_WaitGameplayTagQuery WaitGameplayTagQueryOnActor(AActor TargetActor,FGameplayTagQuery TagQuery,EWaitGameplayTagQueryTriggerCondition TriggerCondition/*=EWaitGameplayTagQueryTriggerCondition.WhenTrue*/,bool bOnlyTriggerOnce/*=false*/) { return default; }
}
