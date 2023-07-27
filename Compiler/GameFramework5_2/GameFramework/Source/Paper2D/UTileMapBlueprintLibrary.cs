#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TileMapBlueprintLibrary.h")]
///<summary>A collection of utility methods for working with tile map components</summary>
public partial class UTileMapBlueprintLibrary : UBlueprintFunctionLibrary {
// TileMapBlueprintLibrary
	public static string GetTileUserData(FPaperTileInfo Tile) { return default; }
	public static FTransform GetTileTransform(FPaperTileInfo Tile) { return default; }
	public static void BreakTile(FPaperTileInfo Tile,int TileIndex,UPaperTileSet TileSet,bool bFlipH,bool bFlipV,bool bFlipD) {}
	public static FPaperTileInfo MakeTile(int TileIndex,UPaperTileSet TileSet,bool bFlipH,bool bFlipV,bool bFlipD) { return default; }
}
