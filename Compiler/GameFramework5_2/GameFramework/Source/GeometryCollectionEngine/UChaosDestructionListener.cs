#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosBlueprint.h")]
///<summary>Object allowing for retrieving Chaos Destruction data.</summary>
public partial class UChaosDestructionListener : USceneComponent {
// ChaosDestructionListener
	public bool bIsCollisionEventListeningEnabled;
	public bool bIsBreakingEventListeningEnabled;
	public bool bIsTrailingEventListeningEnabled;
	public bool bIsRemovalEventListeningEnabled;
	public FChaosCollisionEventRequestSettings CollisionEventRequestSettings;
	public FChaosBreakingEventRequestSettings BreakingEventRequestSettings;
	public FChaosTrailingEventRequestSettings TrailingEventRequestSettings;
	public FChaosRemovalEventRequestSettings RemovalEventRequestSettings;
	public TSet<AChaosSolverActor> ChaosSolverActors;
	public TSet<AGeometryCollectionActor> GeometryCollectionActors;
	public  void AddChaosSolverActor(AChaosSolverActor ChaosSolverActor) {}
	public  void RemoveChaosSolverActor(AChaosSolverActor ChaosSolverActor) {}
	public  void AddGeometryCollectionActor(AGeometryCollectionActor GeometryCollectionActor) {}
	public  void RemoveGeometryCollectionActor(AGeometryCollectionActor GeometryCollectionActor) {}
	public  void SetCollisionEventRequestSettings(FChaosCollisionEventRequestSettings InSettings) {}
	public  void SetBreakingEventRequestSettings(FChaosBreakingEventRequestSettings InSettings) {}
	public  void SetTrailingEventRequestSettings(FChaosTrailingEventRequestSettings InSettings) {}
	public  void SetRemovalEventRequestSettings(FChaosRemovalEventRequestSettings InSettings) {}
	public  void SetCollisionEventEnabled(bool bIsEnabled) {}
	public  void SetBreakingEventEnabled(bool bIsEnabled) {}
	public  void SetTrailingEventEnabled(bool bIsEnabled) {}
	public  void SetRemovalEventEnabled(bool bIsEnabled) {}
	public  bool IsEventListening() { return default; }
	public FOnChaosCollisionEvents OnCollisionEvents;
	public FOnChaosBreakingEvents OnBreakingEvents;
	public FOnChaosTrailingEvents OnTrailingEvents;
	public FOnChaosRemovalEvents OnRemovalEvents;
	public  void SortCollisionEvents(TArray<FChaosCollisionEventData> CollisionEvents,EChaosCollisionSortMethod SortMethod) {}
	public  void SortBreakingEvents(TArray<FChaosBreakingEventData> BreakingEvents,EChaosBreakingSortMethod SortMethod) {}
	public  void SortTrailingEvents(TArray<FChaosTrailingEventData> TrailingEvents,EChaosTrailingSortMethod SortMethod) {}
	public  void SortRemovalEvents(TArray<FChaosRemovalEventData> RemovalEvents,EChaosRemovalSortMethod SortMethod) {}
}
