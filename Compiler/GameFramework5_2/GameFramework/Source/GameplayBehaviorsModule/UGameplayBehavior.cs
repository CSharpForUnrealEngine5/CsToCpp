#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehavior.h")]
public partial class UGameplayBehavior : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>@NOTE on trigger functions - we&quot;ll trigger the most specific one that given behavior implements</summary>
	public  void K2_OnTriggered(AActor Avatar,UGameplayBehaviorConfig Config,AActor SmartObjectOwner) {}
	///<summary>K2_OnTriggeredPawn</summary>
	public  void K2_OnTriggeredPawn(APawn Avatar,UGameplayBehaviorConfig Config,AActor SmartObjectOwner) {}
	///<summary>K2_OnTriggeredCharacter</summary>
	public  void K2_OnTriggeredCharacter(ACharacter Avatar,UGameplayBehaviorConfig Config,AActor SmartObjectOwner) {}
	///<summary>K2_OnFinished</summary>
	public  void K2_OnFinished(AActor Avatar,bool bWasInterrupted) {}
	///<summary>K2_OnFinishedPawn</summary>
	public  void K2_OnFinishedPawn(APawn Avatar,bool bWasInterrupted) {}
	///<summary>K2_OnFinishedCharacter</summary>
	public  void K2_OnFinishedCharacter(ACharacter Avatar,bool bWasInterrupted) {}
	///<summary>K2_EndBehavior</summary>
	public  void K2_EndBehavior(AActor Avatar) {}
	///<summary>K2_AbortBehavior</summary>
	public  void K2_AbortBehavior(AActor Avatar) {}
	///<summary>K2_TriggerBehavior</summary>
	public  void K2_TriggerBehavior(AActor Avatar,UGameplayBehaviorConfig Config/*=nullptr*/,AActor SmartObjectOwner/*=nullptr*/) {}
	///<summary>@return None if there&#39;s no actors or only the one under the index of CurrentIndex is valid</summary>
	public  int K2_GetNextActorIndexInSequence(int CurrentIndex/*=0*/) { return default; }
	///<summary>Tag identifying behavior this class represents</summary>
	public FGameplayTag ActionTag;
	///<summary>It&#39;s up to the behavior implementation to decide how to use these actors.</summary>
	public TArray<AActor> RelevantActors;
	///<summary>SmartObject Actor Owner, can be null</summary>
	public AActor TransientSmartObjectOwner;
	///<summary>Used mostly as world context for IGameplayTaskOwnerInterface function.</summary>
	public AActor TransientAvatar;
	///<summary>List of currently active tasks, do not modify directly</summary>
	public TArray<UGameplayTask> ActiveTasks;
}
