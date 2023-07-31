#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for import data and options used when importing a tile map</summary>
[CppInclude("TileMapAssetImportData.h")]
public partial class UTileMapAssetImportData : UAssetImportData {
	///<summary>TileSetMap</summary>
	public TArray<FTileSetImportMapping> TileSetMap;
}
