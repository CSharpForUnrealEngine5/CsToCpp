#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTasksComponent.h")]
///<summary>The core ActorComponent for interfacing with the GameplayAbilities System</summary>
public partial class UGameplayTasksComponent : UActorComponent {
// GameplayTasksComponent
	public bool bIsNetDirty;
	public TArray<UGameplayTask> TaskPriorityQueue;
	public TArray<UGameplayTask> TickingTasks;
	public TArray<UGameplayTask> KnownTasks;
	public FOnClaimedResourcesChangeSignature OnClaimedResourcesChange;
	public  void OnRep_SimulatedTasks(TArray<UGameplayTask> PreviousSimulatedTasks) {}
	public static EGameplayTaskRunResult K2_RunGameplayTask(object /*TaskOwner*/ TaskOwner,UGameplayTask Task,byte Priority,TArray<UClass> AdditionalRequiredResources,TArray<UClass> AdditionalClaimedResources) { return default; }
	public TArray<UGameplayTask> SimulatedTasks;
}
