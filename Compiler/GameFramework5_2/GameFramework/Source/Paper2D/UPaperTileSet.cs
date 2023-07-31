#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A tile set is a collection of tiles pulled from a texture that can be used to fill out a tile map.</summary>
[CppInclude("PaperTileSet.h")]
public partial class UPaperTileSet : UObject {
	///<summary>The width and height of a single tile (in pixels)</summary>
	public FIntPoint TileSize;
	///<summary>The tile sheet texture associated with this tile set</summary>
	public UTexture2D TileSheet;
	///<summary>Additional source textures for other slots</summary>
	public TArray<UTexture> AdditionalSourceTextures;
	///<summary>The amount of padding around the border of the tile sheet (in pixels)</summary>
	public FIntMargin BorderMargin;
	///<summary>The amount of padding between tiles in the tile sheet (in pixels)</summary>
	public FIntPoint PerTileSpacing;
	///<summary>The drawing offset for tiles from this set (in pixels)</summary>
	public FIntPoint DrawingOffset;
	///<summary>The background color displayed in the tile set viewer</summary>
	public FLinearColor BackgroundColor;
	///<summary>Cached width of this tile set (in tiles)</summary>
	public int WidthInTiles;
	///<summary>Cached height of this tile set (in tiles)</summary>
	public int HeightInTiles;
	///<summary>Allocated width of the per-tile data</summary>
	public int AllocatedWidth;
	///<summary>Allocated height of the per-tile data</summary>
	public int AllocatedHeight;
	///<summary>Per-tile information</summary>
	public TArray<FPaperTileMetadata> PerTileData;
	///<summary>Terrain information</summary>
	public TArray<FPaperTileSetTerrain> Terrains;
	///<summary>TileWidth_DEPRECATED</summary>
	public int TileWidth_DEPRECATED;
	///<summary>TileHeight_DEPRECATED</summary>
	public int TileHeight_DEPRECATED;
	///<summary>Margin_DEPRECATED</summary>
	public int Margin_DEPRECATED;
	///<summary>Spacing_DEPRECATED</summary>
	public int Spacing_DEPRECATED;
}
