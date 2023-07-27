#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehavior.h")]
public partial class UGameplayBehavior : UObject {
// GameplayBehavior
	public  void K2_OnTriggered(AActor Avatar,UGameplayBehaviorConfig Config,AActor SmartObjectOwner) {}
	public  void K2_OnTriggeredPawn(APawn Avatar,UGameplayBehaviorConfig Config,AActor SmartObjectOwner) {}
	public  void K2_OnTriggeredCharacter(ACharacter Avatar,UGameplayBehaviorConfig Config,AActor SmartObjectOwner) {}
	public  void K2_OnFinished(AActor Avatar,bool bWasInterrupted) {}
	public  void K2_OnFinishedPawn(APawn Avatar,bool bWasInterrupted) {}
	public  void K2_OnFinishedCharacter(ACharacter Avatar,bool bWasInterrupted) {}
	public  void K2_EndBehavior(AActor Avatar) {}
	public  void K2_AbortBehavior(AActor Avatar) {}
	public  void K2_TriggerBehavior(AActor Avatar,UGameplayBehaviorConfig Config/*=nullptr*/,AActor SmartObjectOwner/*=nullptr*/) {}
	public  int K2_GetNextActorIndexInSequence(int CurrentIndex/*=0*/) { return default; }
	public FGameplayTag ActionTag;
	public TArray<AActor> RelevantActors;
	public AActor TransientSmartObjectOwner;
	public AActor TransientAvatar;
	public TArray<UGameplayTask> ActiveTasks;
}
