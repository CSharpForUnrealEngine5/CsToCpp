#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Async/AbilityAsync_WaitGameplayTag.h")]
public partial class UAbilityAsync_WaitGameplayTagAdded : UAbilityAsync_WaitGameplayTag {
	///<summary>Added</summary>
	public FAsyncWaitGameplayTagDelegate Added;
	///<summary>Wait until the specified gameplay tag is Added to Target Actor&#39;s ability component</summary>
	public static UAbilityAsync_WaitGameplayTagAdded WaitGameplayTagAddToActor(AActor TargetActor,FGameplayTag Tag,bool OnlyTriggerOnce/*=false*/) { return default; }
}
