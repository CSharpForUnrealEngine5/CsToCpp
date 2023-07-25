#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/WorldPartitionConvertCommandlet.h")]
public partial class UWorldPartitionConvertCommandlet : UCommandlet {
// WorldPartitionConvertCommandlet
	public UClass EditorHashClass;
	public UClass RuntimeHashClass;
	public TArray<string> ExcludedLevels;
	public bool bConvertActorsNotReferencedByLevelScript;
	public FVector WorldOrigin;
	public FVector WorldExtent;
	public string HLODLayerAssetsPath;
	public string DefaultHLODLayerName;
	public string DefaultHLODLayerAsset;
	public string FoliageTypePath;
	public TArray<FHLODLayerActorMapping> HLODLayersForActorClasses;
	public TMap<string,UHLODLayer> HLODLayers;
	public uint LandscapeGridSize;
	public string DataLayerAssetFolder;
	public UDataLayerFactory DataLayerFactory;
}
