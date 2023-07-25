#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TileMapBlueprintLibrary.h")]
///<summary>A collection of utility methods for working with tile map components</summary>
public partial class UTileMapBlueprintLibrary : UBlueprintFunctionLibrary {
// TileMapBlueprintLibrary
	public string GetTileUserData(FPaperTileInfo Tile) { return default; }
	public FTransform GetTileTransform(FPaperTileInfo Tile) { return default; }
	public void BreakTile(FPaperTileInfo Tile,int TileIndex,UObject TileSet,bool bFlipH,bool bFlipV,bool bFlipD) {}
	public FPaperTileInfo MakeTile(int TileIndex,UObject TileSet,bool bFlipH,bool bFlipV,bool bFlipD) { return default; }
}
