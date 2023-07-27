#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Async/AbilityAsync_WaitGameplayTagQuery.h")]
///<summary>This class defines an async node to wait on a gameplay tag query.</summary>
public partial class UAbilityAsync_WaitGameplayTagQuery : UAbilityAsync {
// AbilityAsync_WaitGameplayTagQuery
	public FAsyncWaitGameplayTagQueryDelegate Triggered;
	public static UAbilityAsync_WaitGameplayTagQuery WaitGameplayTagQueryOnActor(AActor TargetActor,FGameplayTagQuery TagQuery,EWaitGameplayTagQueryTriggerCondition TriggerCondition/*=EWaitGameplayTagQueryTriggerCondition.WhenTrue*/,bool bOnlyTriggerOnce/*=false*/) { return default; }
}
