#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/World.h")]
///<summary>The World is the top level object representing a map or a sandbox in which Actors and Components will exist and be rendered.</summary>
public partial class UWorld : UObject {
// World
	public TArray<ULayer> Layers;
	public TArray<AActor> ActiveGroupActors;
	public UThumbnailInfo ThumbnailInfo;
	public ULevel PersistentLevel;
	public UNetDriver NetDriver;
	public ULineBatchComponent LineBatcher;
	public ULineBatchComponent PersistentLineBatcher;
	public ULineBatchComponent ForegroundLineBatcher;
	public AGameNetworkManager NetworkManager;
	public UPhysicsCollisionHandler PhysicsCollisionHandler;
	public TArray<UObject> ExtraReferencedObjects;
	public TArray<UObject> PerModuleDataObjects;
	public TArray<ULevelStreaming> StreamingLevels;
	public FStreamingLevelsToConsider StreamingLevelsToConsider;
	public AServerStreamingLevelsVisibility ServerStreamingLevelsVisibility;
	public string StreamingLevelsPrefix;
	public ULevel CurrentLevelPendingVisibility;
	public ULevel CurrentLevelPendingInvisibility;
	public UDemoNetDriver DemoNetDriver;
	public AParticleEventManager MyParticleEventManager;
	public APhysicsVolume DefaultPhysicsVolume;
	public bool bAreConstraintsDirty;
	public UNavigationSystemBase NavigationSystem;
	public AGameModeBase AuthorityGameMode;
	public AGameStateBase GameState;
	public UAISystemBase AISystem;
	public UAvoidanceManager AvoidanceManager;
	public TArray<ULevel> Levels;
	public TArray<FLevelCollection> LevelCollections;
	public  void HandleTimelineScrubbed() {}
	public ULevel CurrentLevel;
	public UGameInstance OwningGameInstance;
	public TArray<UMaterialParameterCollectionInstance> ParameterCollectionInstances;
	public UCanvas CanvasForRenderingToTarget;
	public UCanvas CanvasForDrawMaterialToRenderTarget;
	public TArray<FLevelViewportInfo> EditorViews;
	public UPhysicsFieldComponent PhysicsField;
	public uint LWILastAssignedUID;
	public TSet<UActorComponent> ComponentsThatNeedPreEndOfFrameSync;
	public TArray<UActorComponent> ComponentsThatNeedEndOfFrameUpdate;
	public TArray<UActorComponent> ComponentsThatNeedEndOfFrameUpdate_OnGameThread;
	public TArray<ULevel> SelectedLevels;
	public UWorldComposition WorldComposition;
	public UContentBundleManager ContentBundleManager;
	public  AWorldSettings K2_GetWorldSettings() { return default; }
	public FWorldPSCPool PSCPool;
}
