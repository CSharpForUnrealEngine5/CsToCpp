#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperTileSet.h")]
///<summary>A tile set is a collection of tiles pulled from a texture that can be used to fill out a tile map.</summary>
public partial class UPaperTileSet : UObject {
// PaperTileSet
	public FIntPoint TileSize;
	public UTexture2D TileSheet;
	public TArray<UTexture> AdditionalSourceTextures;
	public FIntMargin BorderMargin;
	public FIntPoint PerTileSpacing;
	public FIntPoint DrawingOffset;
	public FLinearColor BackgroundColor;
	public int WidthInTiles;
	public int HeightInTiles;
	public int AllocatedWidth;
	public int AllocatedHeight;
	public TArray<FPaperTileMetadata> PerTileData;
	public TArray<FPaperTileSetTerrain> Terrains;
	public int TileWidth_DEPRECATED;
	public int TileHeight_DEPRECATED;
	public int Margin_DEPRECATED;
	public int Spacing_DEPRECATED;
}
