#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/WorldSettings.h")]
///<summary>Actor containing all script accessible world properties.</summary>
public partial class AWorldSettings : AInfo {
// WorldSettings
	public int VisibilityCellSize;
	public byte VisibilityAggressiveness;
	public bool bPrecomputeVisibility;
	public bool bPlaceCellsOnlyAlongCameraTracks;
	public bool bEnableWorldBoundsChecks;
	public bool bEnableNavigationSystem;
	public bool bEnableAISystem;
	public bool bEnableWorldComposition;
	public bool bUseClientSideLevelStreamingVolumes;
	public bool bEnableWorldOriginRebasing;
	public bool bWorldGravitySet;
	public bool bGlobalGravitySet;
	public bool bMinimizeBSPSections;
	public bool bForceNoPrecomputedLighting;
	public bool bHighPriorityLoading;
	public bool bHighPriorityLoadingLocal;
	public bool bOverrideDefaultBroadphaseSettings;
	public bool bGenerateSingleClusterForLevel;
	public bool bIncludeGridSizeInNameForFoliageActors;
	public bool bIncludeGridSizeInNameForPartitionedActors;
	public TSoftObjectPtr<UClass> AISystemClass;
	public FVector LevelInstancePivotOffset;
	public UNavigationSystemConfig NavigationSystemConfig;
	public UNavigationSystemConfig NavigationSystemConfigOverride;
	public UWorldPartition WorldPartition;
	public uint InstancedFoliageGridSize;
	public uint LandscapeSplineMeshesGridSize;
	public uint NavigationDataChunkGridSize;
	public uint NavigationDataBuilderLoadingCellSize;
	public uint DefaultPlacementGridSize;
	public TArray<UDataLayerAsset> BaseNavmeshDataLayers;
	public float WorldToMeters;
	public float KillZ;
	public UClass KillZDamageType;
	public float WorldGravityZ;
	public  void OnRep_WorldGravityZ() {}
	public float GlobalGravityZ;
	public UClass DefaultPhysicsVolumeClass;
	public UClass PhysicsCollisionHandlerClass;
	public UClass DefaultGameMode;
	public UClass GameNetworkManagerClass;
	public int PackedLightAndShadowMapTextureSize;
	public FVector DefaultColorScale;
	public float DefaultMaxDistanceFieldOcclusionDistance;
	public float GlobalDistanceFieldViewDistance;
	public float DynamicIndirectShadowsSelfShadowingIntensity;
	public FLightmassWorldInfoSettings LightmassSettings;
	public FReverbSettings DefaultReverbSettings;
	public FInteriorSettings DefaultAmbientZoneSettings;
	public USoundMix DefaultBaseSoundMix;
	public TSoftObjectPtr<UClass> HLODSetupAsset;
	public TSoftObjectPtr<UMaterialInterface> OverrideBaseMaterial;
	public TArray<FHierarchicalSimplification> HierarchicalLODSetup;
	public int NumHLODLevels;
	public FTransform HLODBakingTransform;
	public UBookMark BookMarks;
	public float TimeDilation;
	public float CinematicTimeDilation;
	public float DemoPlayTimeDilation;
	public float MinGlobalTimeDilation;
	public float MaxGlobalTimeDilation;
	public float MinUndilatedFrameTime;
	public float MaxUndilatedFrameTime;
	public FBroadphaseSettings BroadphaseSettings;
	public TArray<FNetViewer> ReplicationViewers;
	public TArray<UAssetUserData> AssetUserData;
	public APlayerState PauserPlayerState;
	public FWorldPartitionPerWorldSettings DefaultWorldPartitionSettings;
	public int MaxNumberOfBookmarks;
	public UClass DefaultBookmarkClass;
	public TArray<UBookmarkBase> BookmarkArray;
	public UClass LastBookmarkClass;
	public bool bEnableHierarchicalLODSystem_DEPRECATED;
	public bool bEnableLargeWorlds_DEPRECATED;
}
