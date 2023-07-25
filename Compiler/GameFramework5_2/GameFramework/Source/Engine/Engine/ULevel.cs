#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Level.h")]
///<summary>A Level is a collection of Actors (lights, volumes, mesh instances etc.).</summary>
public partial class ULevel : UObject {
// Level
	public TMap<string,AActor> ActorsModifiedForPIE;
	public bool bUseExternalActors;
	public UWorld OwningWorld;
	public UModel Model;
	public TArray<UModelComponent> ModelComponents;
	public ULevelActorContainer ActorCluster;
	public ULevelScriptBlueprint LevelScriptBlueprint;
	public TArray<FGuid> TextureStreamingResourceGuids;
	public int NumTextureStreamingUnbuiltComponents;
	public int NumTextureStreamingDirtyResources;
	public ALevelScriptActor LevelScriptActor;
	public ANavigationObjectBase NavListStart;
	public ANavigationObjectBase NavListEnd;
	public TArray<UNavigationDataChunk> NavDataChunks;
	public float LightmapTotalSize;
	public float ShadowmapTotalSize;
	public TArray<FVector> StaticNavigableGeometry;
	public TArray<FGuid> StreamingTextureGuids;
	public TArray<string> StreamingTextures;
	public uint PackedTextureStreamingQualityLevelFeatureLevel;
	public FGuid LevelBuildDataId;
	public UMapBuildDataRegistry MapBuildData;
	public FIntVector LightBuildLevelOffset;
	public bool bIsLightingScenario;
	public bool bTextureStreamingRotationChanged;
	public bool bStaticComponentsRegisteredInStreamingManager;
	public bool bIsVisible;
	public bool bLocked;
	public bool bIsPartitioned;
	public FLevelSimplificationDetails LevelSimplification;
	public FLinearColor LevelColor;
	public bool bPromptWhenAddingToLevelBeforeCheckout;
	public bool bPromptWhenAddingToLevelOutsideBounds;
	public EActorPackagingScheme ActorPackagingScheme;
	public AWorldSettings WorldSettings;
	public AWorldDataLayers WorldDataLayers;
	public TSoftObjectPtr<UWorldPartitionRuntimeCell> WorldPartitionRuntimeCell;
	public TArray<UAssetUserData> AssetUserData;
	public TArray<FReplicatedStaticActorDestructionInfo> DestroyedReplicatedStaticActors;
	public object /*LevelPartition*/ LevelPartition;
	public TSoftObjectPtr<UObject> OwnerLevelPartition;
	public bool bUseActorFolders;
	public TMap<FGuid,UActorFolder> ActorFolders;
	public TMap<string,FActorFolderSet> FolderLabelToActorFolders;
	public TArray<UActorFolder> LoadedExternalActorFolders;
}
