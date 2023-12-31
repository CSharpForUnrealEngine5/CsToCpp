namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for import data and options used when importing a tile map</summary>
[CppInclude("TileMapAssetImportData.h")]
public partial class UTileMapAssetImportData : UAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>TileSetMap</summary>
	public TArray<FTileSetImportMapping> TileSetMap;
}
