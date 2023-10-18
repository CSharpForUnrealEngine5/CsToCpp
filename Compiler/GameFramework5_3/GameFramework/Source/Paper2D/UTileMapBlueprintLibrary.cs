namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A collection of utility methods for working with tile map components</summary>
[CppInclude("TileMapBlueprintLibrary.h")]
public partial class UTileMapBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the user data name for the specified tile, or NAME_None if there is no user-specified data</summary>
	public static FName GetTileUserData(FPaperTileInfo Tile) { return default; }
	///<summary>Returns the transform for a tile</summary>
	public static FTransform GetTileTransform(FPaperTileInfo Tile) { return default; }
	///<summary>Breaks out the information for a tile</summary>
	public static void BreakTile(FPaperTileInfo Tile,int TileIndex,UPaperTileSet TileSet,bool bFlipH,bool bFlipV,bool bFlipD) {}
	///<summary>Creates a tile from the specified information</summary>
	public static FPaperTileInfo MakeTile(int TileIndex,UPaperTileSet TileSet,bool bFlipH,bool bFlipV,bool bFlipD) { return default; }
}
