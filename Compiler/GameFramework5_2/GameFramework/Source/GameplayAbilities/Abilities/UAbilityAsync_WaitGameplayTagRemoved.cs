#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Async/AbilityAsync_WaitGameplayTag.h")]
public partial class UAbilityAsync_WaitGameplayTagRemoved : UAbilityAsync_WaitGameplayTag {
// AbilityAsync_WaitGameplayTagRemoved
	public FAsyncWaitGameplayTagDelegate Removed;
	public static UAbilityAsync_WaitGameplayTagRemoved WaitGameplayTagRemoveFromActor(AActor TargetActor,FGameplayTag Tag,bool OnlyTriggerOnce/*=false*/) { return default; }
}
