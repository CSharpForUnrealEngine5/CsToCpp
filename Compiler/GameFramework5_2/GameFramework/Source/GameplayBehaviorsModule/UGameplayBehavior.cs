#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehavior.h")]
public partial class UGameplayBehavior : UObject {
// GameplayBehavior
	public void K2_OnTriggered(UObject Avatar,UObject Config,UObject SmartObjectOwner) {}
	public void K2_OnTriggeredPawn(UObject Avatar,UObject Config,UObject SmartObjectOwner) {}
	public void K2_OnTriggeredCharacter(UObject Avatar,UObject Config,UObject SmartObjectOwner) {}
	public void K2_OnFinished(UObject Avatar,bool bWasInterrupted) {}
	public void K2_OnFinishedPawn(UObject Avatar,bool bWasInterrupted) {}
	public void K2_OnFinishedCharacter(UObject Avatar,bool bWasInterrupted) {}
	public void K2_EndBehavior(UObject Avatar) {}
	public void K2_AbortBehavior(UObject Avatar) {}
	public void K2_TriggerBehavior(UObject Avatar,UObject Config/*=nullptr*/,UObject SmartObjectOwner/*=nullptr*/) {}
	public int K2_GetNextActorIndexInSequence(int CurrentIndex/*=0*/) { return default; }
	public FGameplayTag ActionTag;
	public TArray<AActor> RelevantActors;
	public AActor TransientSmartObjectOwner;
	public AActor TransientAvatar;
	public TArray<UGameplayTask> ActiveTasks;
}
