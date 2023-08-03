#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object allowing for retrieving Chaos Destruction data.</summary>
[CppInclude("ChaosBlueprint.h")]
public partial class UChaosDestructionListener : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not collision event listening is enabled</summary>
	public bool bIsCollisionEventListeningEnabled;
	///<summary>Whether or not collision event listening is enabled</summary>
	public bool bIsBreakingEventListeningEnabled;
	///<summary>Whether or not trailing event listening is enabled</summary>
	public bool bIsTrailingEventListeningEnabled;
	///<summary>Whether or not removal event listening is enabled</summary>
	public bool bIsRemovalEventListeningEnabled;
	///<summary>The settings to use for collision event listening</summary>
	public FChaosCollisionEventRequestSettings CollisionEventRequestSettings;
	///<summary>The settings to use for breaking event listening</summary>
	public FChaosBreakingEventRequestSettings BreakingEventRequestSettings;
	///<summary>The settings to use for trailing event listening</summary>
	public FChaosTrailingEventRequestSettings TrailingEventRequestSettings;
	///<summary>The settings to use for removal event listening</summary>
	public FChaosRemovalEventRequestSettings RemovalEventRequestSettings;
	///<summary>Which chaos solver actors we&#39;re using. If empty, this listener will fallback to the &quot;world&quot; solver.</summary>
	public TSet<AChaosSolverActor> ChaosSolverActors;
	///<summary>Which chaos solver actors we&#39;re using. If empty, this listener will fallback to the &quot;world&quot; solver.</summary>
	public TSet<AGeometryCollectionActor> GeometryCollectionActors;
	///<summary>Dynamically adds a chaos solver to the listener</summary>
	public  void AddChaosSolverActor(AChaosSolverActor ChaosSolverActor) {}
	///<summary>Dynamically removes a chaos solver from the listener</summary>
	public  void RemoveChaosSolverActor(AChaosSolverActor ChaosSolverActor) {}
	///<summary>Dynamically adds a chaos solver to the listener</summary>
	public  void AddGeometryCollectionActor(AGeometryCollectionActor GeometryCollectionActor) {}
	///<summary>Dynamically removes a chaos solver from the listener</summary>
	public  void RemoveGeometryCollectionActor(AGeometryCollectionActor GeometryCollectionActor) {}
	///<summary>Sets collision event request settings dynamically</summary>
	public  void SetCollisionEventRequestSettings(FChaosCollisionEventRequestSettings InSettings) {}
	///<summary>Sets breaking event request settings dynamically</summary>
	public  void SetBreakingEventRequestSettings(FChaosBreakingEventRequestSettings InSettings) {}
	///<summary>Sets trailing event request settings dynamically</summary>
	public  void SetTrailingEventRequestSettings(FChaosTrailingEventRequestSettings InSettings) {}
	///<summary>Sets removal event request settings dynamically</summary>
	public  void SetRemovalEventRequestSettings(FChaosRemovalEventRequestSettings InSettings) {}
	///<summary>Enables or disables collision event listening</summary>
	public  void SetCollisionEventEnabled(bool bIsEnabled) {}
	///<summary>Enables or disables breaking event listening</summary>
	public  void SetBreakingEventEnabled(bool bIsEnabled) {}
	///<summary>Enables or disables trailing event listening</summary>
	public  void SetTrailingEventEnabled(bool bIsEnabled) {}
	///<summary>Enables or disables removal event listening</summary>
	public  void SetRemovalEventEnabled(bool bIsEnabled) {}
	///<summary>Returns if the destruction listener is listening to any events</summary>
	public  bool IsEventListening() { return default; }
	///<summary>Called when new collision events are available.</summary>
	public FOnChaosCollisionEvents OnCollisionEvents;
	///<summary>Called when new breaking events are available.</summary>
	public FOnChaosBreakingEvents OnBreakingEvents;
	///<summary>Called when new trailing events are available.</summary>
	public FOnChaosTrailingEvents OnTrailingEvents;
	///<summary>Called when new trailing events are available.</summary>
	public FOnChaosRemovalEvents OnRemovalEvents;
	///<summary>Sorts collision events according to the given sort method</summary>
	public  void SortCollisionEvents(TArray<FChaosCollisionEventData> CollisionEvents,EChaosCollisionSortMethod SortMethod) {}
	///<summary>Sorts breaking events according to the given sort method</summary>
	public  void SortBreakingEvents(TArray<FChaosBreakingEventData> BreakingEvents,EChaosBreakingSortMethod SortMethod) {}
	///<summary>Sorts trailing events according to the given sort method</summary>
	public  void SortTrailingEvents(TArray<FChaosTrailingEventData> TrailingEvents,EChaosTrailingSortMethod SortMethod) {}
	///<summary>Sorts removal events according to the given sort method</summary>
	public  void SortRemovalEvents(TArray<FChaosRemovalEventData> RemovalEvents,EChaosRemovalSortMethod SortMethod) {}
}
