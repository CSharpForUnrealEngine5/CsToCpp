#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The World is the top level object representing a map or a sandbox in which Actors and Components will exist and be rendered.</summary>
[CppInclude("Engine/World.h")]
public partial class UWorld : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>List of all the layers referenced by the world&#39;s actors</summary>
	public TArray<ULayer> Layers;
	///<summary>Group actors currently &quot;active&quot;</summary>
	public TArray<AActor> ActiveGroupActors;
	///<summary>Information for thumbnail rendering</summary>
	public UThumbnailInfo ThumbnailInfo;
	///<summary>Persistent level containing the world info, default brush and actors spawned during gameplay among other things</summary>
	public ULevel PersistentLevel;
	///<summary>The NAME_GameNetDriver game connection(s) for client/server communication</summary>
	public UNetDriver NetDriver;
	///<summary>Line Batchers. All lines to be drawn in the world.</summary>
	public ULineBatchComponent LineBatcher;
	///<summary>Persistent Line Batchers. They don&#39;t get flushed every frame.</summary>
	public ULineBatchComponent PersistentLineBatcher;
	///<summary>Foreground Line Batchers. This can&#39;t be Persistent.</summary>
	public ULineBatchComponent ForegroundLineBatcher;
	///<summary>Instance of this world&#39;s game-specific networking management</summary>
	public AGameNetworkManager NetworkManager;
	///<summary>Instance of this world&#39;s game-specific physics collision handler</summary>
	public UPhysicsCollisionHandler PhysicsCollisionHandler;
	///<summary>Array of any additional objects that need to be referenced by this world, to make sure they aren&#39;t GC&#39;d</summary>
	public TArray<UObject> ExtraReferencedObjects;
	///<summary>External modules can have additional data associated with this UWorld.</summary>
	public TArray<UObject> PerModuleDataObjects;
	///<summary>Level collection. ULevels are referenced by FName (Package name) to avoid serialized references. Also contains offsets in world units</summary>
	public TArray<ULevelStreaming> StreamingLevels;
	///<summary>This is the list of streaming levels that are actively being considered for what their state should be. It will be a subset of StreamingLevels</summary>
	public FStreamingLevelsToConsider StreamingLevelsToConsider;
	///<summary>ServerStreamingLevelsVisibility</summary>
	public AServerStreamingLevelsVisibility ServerStreamingLevelsVisibility;
	///<summary>Prefix we used to rename streaming levels, non empty in PIE and standalone preview</summary>
	public string StreamingLevelsPrefix;
	///<summary>Pointer to the current level in the queue to be made visible, NULL if none are pending.</summary>
	public ULevel CurrentLevelPendingVisibility;
	///<summary>Pointer to the current level in the queue to be made invisible, NULL if none are pending.</summary>
	public ULevel CurrentLevelPendingInvisibility;
	///<summary>NetDriver for capturing network traffic to record demos</summary>
	public UDemoNetDriver DemoNetDriver;
	///<summary>Particle event manager *</summary>
	public AParticleEventManager MyParticleEventManager;
	///<summary>DefaultPhysicsVolume used for whole game *</summary>
	public APhysicsVolume DefaultPhysicsVolume;
	///<summary>Keeps track whether actors moved via PostEditMove and therefore constraint syncup should be performed.</summary>
	public bool bAreConstraintsDirty;
	///<summary>The world&#39;s navigation data manager</summary>
	public UNavigationSystemBase NavigationSystem;
	///<summary>The current GameMode, valid only on the server</summary>
	public AGameModeBase AuthorityGameMode;
	///<summary>The replicated actor which contains game state information that can be accessible to clients. Direct access is not allowed, use GetGameState&lt;&gt;()</summary>
	public AGameStateBase GameState;
	///<summary>The AI System handles generating pathing information and AI behavior</summary>
	public UAISystemBase AISystem;
	///<summary>RVO avoidance manager used by game</summary>
	public UAvoidanceManager AvoidanceManager;
	///<summary>Array of levels currently in this world. Not serialized to disk to avoid hard references.</summary>
	public TArray<ULevel> Levels;
	///<summary>Array of level collections currently in this world.</summary>
	public TArray<FLevelCollection> LevelCollections;
	///<summary>Called from DemoNetDriver when playing back a replay and the timeline is successfully scrubbed</summary>
	public  void HandleTimelineScrubbed() {}
	///<summary>Pointer to the current level being edited. Level has to be in the Levels array and == PersistentLevel in the game.</summary>
	public ULevel CurrentLevel;
	///<summary>OwningGameInstance</summary>
	public UGameInstance OwningGameInstance;
	///<summary>Parameter collection instances that hold parameter overrides for this world.</summary>
	public TArray<UMaterialParameterCollectionInstance> ParameterCollectionInstances;
	///<summary>Canvas object used for drawing to render targets from blueprint functions eg DrawMaterialToRenderTarget.</summary>
	public UCanvas CanvasForRenderingToTarget;
	///<summary>CanvasForDrawMaterialToRenderTarget</summary>
	public UCanvas CanvasForDrawMaterialToRenderTarget;
	///<summary>Saved editor viewport states - one for each view type. Indexed using ELevelViewportType from UnrealEdTypes.h.</summary>
	public TArray<FLevelViewportInfo> EditorViews;
	///<summary>Physics Field component.</summary>
	public UPhysicsFieldComponent PhysicsField;
	///<summary>Tracks the last assigned unique id for light weight instances in this world.</summary>
	public uint LWILastAssignedUID;
	///<summary>Array of components that need to wait on tasks before end of frame updates</summary>
	public TSet<UActorComponent> ComponentsThatNeedPreEndOfFrameSync;
	///<summary>Array of components that need updates at the end of the frame</summary>
	public TArray<UActorComponent> ComponentsThatNeedEndOfFrameUpdate;
	///<summary>Array of components that need game thread updates at the end of the frame</summary>
	public TArray<UActorComponent> ComponentsThatNeedEndOfFrameUpdate_OnGameThread;
	///<summary>Array of selected levels currently in this world. Not serialized to disk to avoid hard references.</summary>
	public TArray<ULevel> SelectedLevels;
	///<summary>All levels information from which our world is composed</summary>
	public UWorldComposition WorldComposition;
	///<summary>ContentBundleManager</summary>
	public UContentBundleManager ContentBundleManager;
	///<summary>Returns the AWorldSettings actor associated with this world.</summary>
	public  AWorldSettings K2_GetWorldSettings() { return default; }
	///<summary>PSCPool</summary>
	public FWorldPSCPool PSCPool;
}
