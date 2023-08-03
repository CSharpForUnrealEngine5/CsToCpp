#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A tile map is a 2D grid with a defined width and height (in tiles).  There can be multiple layers, each of which can specify which tile should appear in each cell of the map for that layer.</summary>
[CppInclude("PaperTileMap.h")]
public partial class UPaperTileMap : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Width of map (in tiles)</summary>
	public int MapWidth;
	///<summary>Height of map (in tiles)</summary>
	public int MapHeight;
	///<summary>Width of one tile (in pixels)</summary>
	public int TileWidth;
	///<summary>Height of one tile (in pixels)</summary>
	public int TileHeight;
	///<summary>The scaling factor between pixels and Unreal units (cm) (e.g., 0.64 would make a 64 pixel wide tile take up 100 cm)</summary>
	public float PixelsPerUnrealUnit;
	///<summary>The Z-separation incurred as you travel in X (not strictly applied, batched tiles will be put at the same Z level)</summary>
	public float SeparationPerTileX;
	///<summary>The Z-separation incurred as you travel in Y (not strictly applied, batched tiles will be put at the same Z level)</summary>
	public float SeparationPerTileY;
	///<summary>The Z-separation between each layer of the tile map</summary>
	public float SeparationPerLayer;
	///<summary>Last tile set that was selected when editing the tile map</summary>
	public TSoftObjectPtr<UPaperTileSet> SelectedTileSet;
	///<summary>The material to use on a tile map instance if not overridden</summary>
	public UMaterialInterface Material;
	///<summary>The list of layers</summary>
	public TArray<UPaperTileLayer> TileLayers;
	///<summary>The extrusion thickness of collision geometry when using a 3D collision domain</summary>
	public float CollisionThickness;
	///<summary>Collision domain (no collision, 2D, or 3D)</summary>
	public ESpriteCollisionMode SpriteCollisionDomain;
	///<summary>Tile map type</summary>
	public ETileMapProjectionMode ProjectionMode;
	///<summary>The vertical height of the sides of the hex cell for a tile.</summary>
	public int HexSideLength;
	///<summary>Baked physics data.</summary>
	public UBodySetup BodySetup;
	///<summary>Importing data and options used for this tile map</summary>
	public UAssetImportData AssetImportData;
	///<summary>The currently selected layer index</summary>
	public int SelectedLayerIndex;
	///<summary>The background color displayed in the tile map editor</summary>
	public FLinearColor BackgroundColor;
	///<summary>The color of the tile grid</summary>
	public FLinearColor TileGridColor;
	///<summary>The color of the multi tile grid</summary>
	public FLinearColor MultiTileGridColor;
	///<summary>Number of tiles the multi tile grid spans horizontally. 0 removes vertical lines</summary>
	public int MultiTileGridWidth;
	///<summary>Number of tiles the multi tile grid spans vertically. 0 removes horizontal lines</summary>
	public int MultiTileGridHeight;
	///<summary>Number of tiles the multi tile grid is shifted to the right</summary>
	public int MultiTileGridOffsetX;
	///<summary>Number of tiles the multi tile grid is shifted downwards</summary>
	public int MultiTileGridOffsetY;
	///<summary>The color of the layer grid</summary>
	public FLinearColor LayerGridColor;
	///<summary>The naming index to start at when trying to create a new layer</summary>
	public int LayerNameIndex;
}
