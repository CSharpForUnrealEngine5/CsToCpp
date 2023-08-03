#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor containing all script accessible world properties.</summary>
[CppInclude("GameFramework/WorldSettings.h")]
public partial class AWorldSettings : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>World space size of precomputed visibility cells in x and y.</summary>
	public int VisibilityCellSize;
	///<summary>Determines how aggressive precomputed visibility should be.</summary>
	public EVisibilityAggressiveness VisibilityAggressiveness;
	///<summary>Whether to place visibility cells inside Precomputed Visibility Volumes and along camera tracks in this level.</summary>
	public bool bPrecomputeVisibility;
	///<summary>Whether to place visibility cells only along camera tracks or only above shadow casting surfaces.</summary>
	public bool bPlaceCellsOnlyAlongCameraTracks;
	///<summary>If true, enables CheckStillInWorld checks</summary>
	public bool bEnableWorldBoundsChecks;
	///<summary>bEnableNavigationSystem</summary>
	public bool bEnableNavigationSystem;
	///<summary>if set to false AI system will not get created. Use it to disable all AI-related activity on a map</summary>
	public bool bEnableAISystem;
	///<summary>Enables tools for composing a tiled world.</summary>
	public bool bEnableWorldComposition;
	///<summary>Enables client-side streaming volumes instead of server-side.</summary>
	public bool bUseClientSideLevelStreamingVolumes;
	///<summary>World origin will shift to a camera position when camera goes far away from current origin</summary>
	public bool bEnableWorldOriginRebasing;
	///<summary>if set to true, when we call GetGravityZ we assume WorldGravityZ has already been initialized and skip the lookup of DefaultGravityZ and GlobalGravityZ</summary>
	public bool bWorldGravitySet;
	///<summary>If set to true we will use GlobalGravityZ instead of project setting DefaultGravityZ</summary>
	public bool bGlobalGravitySet;
	///<summary>Causes the BSP build to generate as few sections as possible.</summary>
	public bool bMinimizeBSPSections;
	///<summary>Whether to force lightmaps and other precomputed lighting to not be created even when the engine thinks they are needed.</summary>
	public bool bForceNoPrecomputedLighting;
	///<summary>when this flag is set, more time is allocated to background loading (replicated)</summary>
	public bool bHighPriorityLoading;
	///<summary>copy of bHighPriorityLoading that is not replicated, for clientside-only loading operations</summary>
	public bool bHighPriorityLoadingLocal;
	///<summary>bOverrideDefaultBroadphaseSettings</summary>
	public bool bOverrideDefaultBroadphaseSettings;
	///<summary>If set to true, all eligible actors in this level will be added to a single cluster representing the entire level (used for small sublevels)</summary>
	public bool bGenerateSingleClusterForLevel;
	///<summary>Whether Foliage actors of this world contain their grid size in their name. This should only be changed by UWorldPartitionFoliageBuilder or when creating new worlds so that older worlds are unaffected</summary>
	public bool bIncludeGridSizeInNameForFoliageActors;
	///<summary>Whether partitioned actors of this world contain their grid size in their name. This should only be changed when creating new worlds so that older worlds are unaffected</summary>
	public bool bIncludeGridSizeInNameForPartitionedActors;
	///<summary>AISystemClass</summary>
	public TSoftObjectPtr<UClass> AISystemClass;
	///<summary>Additional transform applied when applying LevelStreaming Transform to LevelInstance</summary>
	public FVector LevelInstancePivotOffset;
	///<summary>Holds parameters for NavigationSystem&#39;s creation. Set to Null will result</summary>
	public UNavigationSystemConfig NavigationSystemConfig;
	///<summary>Overrides NavigationSystemConfig.</summary>
	public UNavigationSystemConfig NavigationSystemConfigOverride;
	///<summary>WorldPartition</summary>
	public UWorldPartition WorldPartition;
	///<summary>Size of the grid for instanced foliage actors, only used for partitioned worlds</summary>
	public uint InstancedFoliageGridSize;
	///<summary>LandscapeSplineMeshesGridSize</summary>
	public uint LandscapeSplineMeshesGridSize;
	///<summary>Size of the grid for navigation data chunk actors</summary>
	public uint NavigationDataChunkGridSize;
	///<summary>Loading cell size used when building navigation data iteratively.</summary>
	public uint NavigationDataBuilderLoadingCellSize;
	///<summary>Default size of the grid for placed elements from the editor</summary>
	public uint DefaultPlacementGridSize;
	///<summary>A list of runtime data layers that should be included in the base navmesh.</summary>
	public TArray<UDataLayerAsset> BaseNavmeshDataLayers;
	///<summary>scale of 1uu to 1m in real world measurements, for HMD and other physically tracked devices (e.g. 1uu = 1cm would be 100.0)</summary>
	public float WorldToMeters;
	///<summary>any actor falling below this level gets destroyed</summary>
	public float KillZ;
	///<summary>The type of damage inflicted when a actor falls below KillZ</summary>
	public UClass KillZDamageType;
	///<summary>current gravity actually being used</summary>
	public float WorldGravityZ;
	///<summary>OnRep_WorldGravityZ</summary>
	public  void OnRep_WorldGravityZ() {}
	///<summary>optional level specific gravity override set by level designer</summary>
	public float GlobalGravityZ;
	///<summary>level specific default physics volume</summary>
	public UClass DefaultPhysicsVolumeClass;
	///<summary>optional level specific collision handler</summary>
	public UClass PhysicsCollisionHandlerClass;
	///<summary>The default GameMode to use when starting this map in the game. If this value is NULL, the INI setting for default game type is used.</summary>
	public UClass DefaultGameMode;
	///<summary>Class of GameNetworkManager to spawn for network games</summary>
	public UClass GameNetworkManagerClass;
	///<summary>Maximum size of textures for packed light and shadow maps</summary>
	public int PackedLightAndShadowMapTextureSize;
	///<summary>Default color scale for the level</summary>
	public FVector DefaultColorScale;
	///<summary>Max occlusion distance used by mesh distance fields, overridden if there is a movable skylight.</summary>
	public float DefaultMaxDistanceFieldOcclusionDistance;
	///<summary>Distance from the camera that the global distance field should cover.</summary>
	public float GlobalDistanceFieldViewDistance;
	///<summary>Controls the intensity of self-shadowing from capsule indirect shadows.</summary>
	public float DynamicIndirectShadowsSelfShadowingIntensity;
	///<summary>LIGHTMASS RELATED SETTINGS *</summary>
	public FLightmassWorldInfoSettings LightmassSettings;
	///<summary>Default reverb settings used by audio volumes.</summary>
	public FReverbSettings DefaultReverbSettings;
	///<summary>Default interior settings applied to sounds that have &quot;apply ambient volumes&quot; set to true on their SoundClass.</summary>
	public FInteriorSettings DefaultAmbientZoneSettings;
	///<summary>Default Base SoundMix.</summary>
	public USoundMix DefaultBaseSoundMix;
	///<summary>If set overrides the level settings and global project settings</summary>
	public TSoftObjectPtr<UClass> HLODSetupAsset;
	///<summary>If set overrides the project-wide base material used for Proxy Materials</summary>
	public TSoftObjectPtr<UMaterialInterface> OverrideBaseMaterial;
	///<summary>Hierarchical LOD Setup</summary>
	public TArray<FHierarchicalSimplification> HierarchicalLODSetup;
	///<summary>NumHLODLevels</summary>
	public int NumHLODLevels;
	///<summary>Specify the transform to apply to the source meshes when building HLODs.</summary>
	public FTransform HLODBakingTransform;
	///<summary>BookMarks</summary>
	public UBookMark BookMarks;
	///<summary>Normally 1 - scales real time passage.</summary>
	public float TimeDilation;
	///<summary>Additional time dilation used by Sequencer slomo track.  Transient because this is often</summary>
	public float CinematicTimeDilation;
	///<summary>Additional TimeDilation used to control demo playback speed</summary>
	public float DemoPlayTimeDilation;
	///<summary>Lowest acceptable global time dilation.</summary>
	public float MinGlobalTimeDilation;
	///<summary>Highest acceptable global time dilation.</summary>
	public float MaxGlobalTimeDilation;
	///<summary>Smallest possible frametime, not considering dilation. Equiv to 1/FastestFPS.</summary>
	public float MinUndilatedFrameTime;
	///<summary>Largest possible frametime, not considering dilation. Equiv to 1/SlowestFPS.</summary>
	public float MaxUndilatedFrameTime;
	///<summary>BroadphaseSettings</summary>
	public FBroadphaseSettings BroadphaseSettings;
	///<summary>valid only during replication - information about the player(s) being replicated to</summary>
	public TArray<FNetViewer> ReplicationViewers;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
	///<summary>If paused, PlayerState of person pausing the game.</summary>
	public APlayerState PauserPlayerState;
	///<summary>DefaultWorldPartitionSettings</summary>
	public FWorldPartitionPerWorldSettings DefaultWorldPartitionSettings;
	///<summary>Maximum number of bookmarks allowed.</summary>
	public int MaxNumberOfBookmarks;
	///<summary>Class that will be used when creating new bookmarks.</summary>
	public UClass DefaultBookmarkClass;
	///<summary>BookmarkArray</summary>
	public TArray<UBookmarkBase> BookmarkArray;
	///<summary>Tracked so we can detect changes from Config</summary>
	public UClass LastBookmarkClass;
	///<summary>DEPRECATED</summary>
	public bool bEnableHierarchicalLODSystem_DEPRECATED;
	///<summary>bEnableLargeWorlds_DEPRECATED</summary>
	public bool bEnableLargeWorlds_DEPRECATED;
}
