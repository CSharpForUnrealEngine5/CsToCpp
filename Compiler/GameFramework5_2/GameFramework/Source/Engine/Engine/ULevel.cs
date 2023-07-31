#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Level is a collection of Actors (lights, volumes, mesh instances etc.).</summary>
[CppInclude("Engine/Level.h")]
public partial class ULevel : UObject {
	///<summary>List of modified, unsaved actors that needs to be duplicated for PIE</summary>
	public TMap<string,AActor> ActorsModifiedForPIE;
	///<summary>Use external actors, new actor spawned in this level will be external and existing external actors will be loaded on load.</summary>
	public bool bUseExternalActors;
	///<summary>The World that has this level in its Levels array.</summary>
	public UWorld OwningWorld;
	///<summary>BSP UModel.</summary>
	public UModel Model;
	///<summary>BSP Model components used for rendering.</summary>
	public TArray<UModelComponent> ModelComponents;
	///<summary>ActorCluster</summary>
	public ULevelActorContainer ActorCluster;
	///<summary>Reference to the blueprint for level scripting</summary>
	public ULevelScriptBlueprint LevelScriptBlueprint;
	///<summary>The Guid list of all materials and meshes Guid used in the last texture streaming build. Used to know if the streaming data needs rebuild. Only used for the persistent level.</summary>
	public TArray<FGuid> TextureStreamingResourceGuids;
	///<summary>Num of components missing valid texture streaming data. Updated in map check.</summary>
	public int NumTextureStreamingUnbuiltComponents;
	///<summary>Num of resources that have changed since the last texture streaming build. Updated in map check.</summary>
	public int NumTextureStreamingDirtyResources;
	///<summary>The level scripting actor, created by instantiating the class from LevelScriptBlueprint.  This handles all level scripting</summary>
	public ALevelScriptActor LevelScriptActor;
	///<summary>Start and end of the navigation list for this level, used for quickly fixing up</summary>
	public ANavigationObjectBase NavListStart;
	///<summary>NavListEnd</summary>
	public ANavigationObjectBase NavListEnd;
	///<summary>Navigation related data that can be stored per level</summary>
	public TArray<UNavigationDataChunk> NavDataChunks;
	///<summary>Total number of KB used for lightmap textures in the level.</summary>
	public float LightmapTotalSize;
	///<summary>Total number of KB used for shadowmap textures in the level.</summary>
	public float ShadowmapTotalSize;
	///<summary>threes of triangle vertices - AABB filtering friendly. Stored if there&#39;s a runtime need to rebuild navigation that accepts BSPs</summary>
	public TArray<FVector> StaticNavigableGeometry;
	///<summary>The Guid of each streamable texture refered by FStreamingTextureBuildInfo::TextureLevelIndex</summary>
	public TArray<FGuid> StreamingTextureGuids;
	///<summary>The name of each streamable texture referred by FStreamingTextureBuildInfo::TextureLevelIndex</summary>
	public TArray<string> StreamingTextures;
	///<summary>Packed quality level and feature level used when building texture streaming data. This is used by runtime to determine if built data can be used or not.</summary>
	public uint PackedTextureStreamingQualityLevelFeatureLevel;
	///<summary>Identifies map build data specific to this level, eg lighting volume samples.</summary>
	public FGuid LevelBuildDataId;
	///<summary>Registry for data from the map build.  This is stored in a separate package from the level to speed up saving / autosaving.</summary>
	public UMapBuildDataRegistry MapBuildData;
	///<summary>Level offset at time when lighting was built</summary>
	public FIntVector LightBuildLevelOffset;
	///<summary>Whether the level is a lighting scenario.  Lighting is built separately for each lighting scenario level with all other scenario levels hidden.</summary>
	public bool bIsLightingScenario;
	///<summary>Whether a level transform rotation was applied since the texture streaming builds. Invalidates the precomputed streaming bounds.</summary>
	public bool bTextureStreamingRotationChanged;
	///<summary>Whether the level has finished registering all static components in the streaming manager.</summary>
	public bool bStaticComponentsRegisteredInStreamingManager;
	///<summary>Whether the level is currently visible/ associated with the world.</summary>
	public bool bIsVisible;
	///<summary>Whether this level is locked; that is, its actors are read-only</summary>
	public bool bLocked;
	///<summary>Whether the level is partitioned or not.</summary>
	public bool bIsPartitioned;
	///<summary>Level simplification settings for each LOD</summary>
	public FLevelSimplificationDetails LevelSimplification;
	///<summary>The level color used for visualization. (Show -&gt; Advanced -&gt; Level Coloration)</summary>
	public FLinearColor LevelColor;
	///<summary>bPromptWhenAddingToLevelBeforeCheckout</summary>
	public bool bPromptWhenAddingToLevelBeforeCheckout;
	///<summary>bPromptWhenAddingToLevelOutsideBounds</summary>
	public bool bPromptWhenAddingToLevelOutsideBounds;
	///<summary>ActorPackagingScheme</summary>
	public EActorPackagingScheme ActorPackagingScheme;
	///<summary>WorldSettings</summary>
	public AWorldSettings WorldSettings;
	///<summary>WorldDataLayers</summary>
	public AWorldDataLayers WorldDataLayers;
	///<summary>WorldPartitionRuntimeCell</summary>
	public TSoftObjectPtr<UWorldPartitionRuntimeCell> WorldPartitionRuntimeCell;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
	///<summary>List of replicated static actors that have been destroyed. Used by net drivers to replicate destruction to clients.</summary>
	public TArray<FReplicatedStaticActorDestructionInfo> DestroyedReplicatedStaticActors;
	///<summary>Level partition, if any</summary>
	public object /*LevelPartition*/ LevelPartition;
	///<summary>When the level is partitioned, this will point to the owner partition (will be the same as this-&gt;LevelPartition in case that is the top partition level</summary>
	public TSoftObjectPtr<UObject> OwnerLevelPartition;
	///<summary>Use actor folder objects, actor folders of this level will be persistent in their own object.</summary>
	public bool bUseActorFolders;
	///<summary>Actor folder objects. They can either be saved inside level or in their own package.</summary>
	public TMap<FGuid,UActorFolder> ActorFolders;
	///<summary>Acceleration table used to find an ActorFolder object for a given folder path.</summary>
	public TMap<string,FActorFolderSet> FolderLabelToActorFolders;
	///<summary>Temporary array containing actor folder objects manually loaded from their external packages (only used while loading the level).</summary>
	public TArray<UActorFolder> LoadedExternalActorFolders;
}
