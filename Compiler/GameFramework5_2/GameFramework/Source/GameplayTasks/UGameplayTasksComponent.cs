#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The core ActorComponent for interfacing with the GameplayAbilities System</summary>
[CppInclude("GameplayTasksComponent.h")]
public partial class UGameplayTasksComponent : UActorComponent {
	///<summary>Set to indicate that GameplayTasksComponent needs immediate replication. @TODO could just use ForceReplication(), but this allows initial implementation to be game specific.</summary>
	public bool bIsNetDirty;
	///<summary>TaskPriorityQueue</summary>
	public TArray<UGameplayTask> TaskPriorityQueue;
	///<summary>Array of currently active UGameplayTask that require ticking</summary>
	public TArray<UGameplayTask> TickingTasks;
	///<summary>All known tasks (processed by this component) referenced for GC</summary>
	public TArray<UGameplayTask> KnownTasks;
	///<summary>OnClaimedResourcesChange</summary>
	public FOnClaimedResourcesChangeSignature OnClaimedResourcesChange;
	///<summary>OnRep_SimulatedTasks</summary>
	public  void OnRep_SimulatedTasks(TArray<UGameplayTask> PreviousSimulatedTasks) {}
	///<summary>K2_RunGameplayTask</summary>
	public static EGameplayTaskRunResult K2_RunGameplayTask(object /*TaskOwner*/ TaskOwner,UGameplayTask Task,byte Priority,TArray<UClass> AdditionalRequiredResources,TArray<UClass> AdditionalClaimedResources) { return default; }
	///<summary>Tasks that run on simulated proxies</summary>
	public TArray<UGameplayTask> SimulatedTasks;
}
