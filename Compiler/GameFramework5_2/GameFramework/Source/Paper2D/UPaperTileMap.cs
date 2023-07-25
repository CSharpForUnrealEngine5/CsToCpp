#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperTileMap.h")]
///<summary>A tile map is a 2D grid with a defined width and height (in tiles).  There can be multiple layers, each of which can specify which tile should appear in each cell of the map for that layer.</summary>
public partial class UPaperTileMap : UObject {
// PaperTileMap
	public int MapWidth;
	public int MapHeight;
	public int TileWidth;
	public int TileHeight;
	public float PixelsPerUnrealUnit;
	public float SeparationPerTileX;
	public float SeparationPerTileY;
	public float SeparationPerLayer;
	public TSoftObjectPtr<UPaperTileSet> SelectedTileSet;
	public UMaterialInterface Material;
	public TArray<UPaperTileLayer> TileLayers;
	public float CollisionThickness;
	public byte SpriteCollisionDomain;
	public byte ProjectionMode;
	public int HexSideLength;
	public UBodySetup BodySetup;
	public UAssetImportData AssetImportData;
	public int SelectedLayerIndex;
	public FLinearColor BackgroundColor;
	public FLinearColor TileGridColor;
	public FLinearColor MultiTileGridColor;
	public int MultiTileGridWidth;
	public int MultiTileGridHeight;
	public int MultiTileGridOffsetX;
	public int MultiTileGridOffsetY;
	public FLinearColor LayerGridColor;
	public int LayerNameIndex;
}
