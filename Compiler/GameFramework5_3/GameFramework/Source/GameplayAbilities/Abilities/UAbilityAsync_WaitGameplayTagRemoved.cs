namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Async/AbilityAsync_WaitGameplayTag.h")]
public partial class UAbilityAsync_WaitGameplayTagRemoved : UAbilityAsync_WaitGameplayTag {
	public static UClass StaticClass() {return default;}
	///<summary>Removed</summary>
	public FAsyncWaitGameplayTagDelegate Removed;
	///<summary>Wait until the specified gameplay tag is Removed from Target Actor&#39;s ability component</summary>
	public static UAbilityAsync_WaitGameplayTagRemoved WaitGameplayTagRemoveFromActor(AActor TargetActor,FGameplayTag Tag,bool OnlyTriggerOnce/*=false*/) { return default; }
}
