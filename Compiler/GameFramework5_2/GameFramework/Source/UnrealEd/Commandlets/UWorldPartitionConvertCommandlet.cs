namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/WorldPartitionConvertCommandlet.h")]
public partial class UWorldPartitionConvertCommandlet : UCommandlet {
	public static UClass StaticClass() {return default;}
	///<summary>EditorHashClass</summary>
	public UClass EditorHashClass;
	///<summary>RuntimeHashClass</summary>
	public UClass RuntimeHashClass;
	///<summary>Levels excluded from conversion.</summary>
	public TArray<string> ExcludedLevels;
	///<summary>bConvertActorsNotReferencedByLevelScript</summary>
	public bool bConvertActorsNotReferencedByLevelScript;
	///<summary>WorldOrigin</summary>
	public FVector WorldOrigin;
	///<summary>WorldExtent</summary>
	public FVector WorldExtent;
	///<summary>HLODLayerAssetsPath</summary>
	public string HLODLayerAssetsPath;
	///<summary>DefaultHLODLayerName</summary>
	public string DefaultHLODLayerName;
	///<summary>DefaultHLODLayerAsset</summary>
	public string DefaultHLODLayerAsset;
	///<summary>FoliageTypePath</summary>
	public string FoliageTypePath;
	///<summary>HLODLayersForActorClasses</summary>
	public TArray<FHLODLayerActorMapping> HLODLayersForActorClasses;
	///<summary>HLODLayers</summary>
	public TMap<string,UHLODLayer> HLODLayers;
	///<summary>LandscapeGridSize</summary>
	public uint LandscapeGridSize;
	///<summary>DataLayerAssetFolder</summary>
	public string DataLayerAssetFolder;
	///<summary>DataLayerFactory</summary>
	public UDataLayerFactory DataLayerFactory;
}
