#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that handles rendering and collision for a single instance of a UPaperTileMap asset.</summary>
[CppInclude("PaperTileMapComponent.h")]
public partial class UPaperTileMapComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>MapWidth_DEPRECATED</summary>
	public int MapWidth_DEPRECATED;
	///<summary>MapHeight_DEPRECATED</summary>
	public int MapHeight_DEPRECATED;
	///<summary>TileWidth_DEPRECATED</summary>
	public int TileWidth_DEPRECATED;
	///<summary>TileHeight_DEPRECATED</summary>
	public int TileHeight_DEPRECATED;
	///<summary>DefaultLayerTileSet_DEPRECATED</summary>
	public UPaperTileSet DefaultLayerTileSet_DEPRECATED;
	///<summary>Material_DEPRECATED</summary>
	public UMaterialInterface Material_DEPRECATED;
	///<summary>TileLayers_DEPRECATED</summary>
	public TArray<UPaperTileLayer> TileLayers_DEPRECATED;
	///<summary>The color of the tile map (multiplied with the per-layer color and passed to the material as a vertex color)</summary>
	public FLinearColor TileMapColor;
	///<summary>The index of the single layer to use if enabled</summary>
	public int UseSingleLayerIndex;
	///<summary>Should we draw a single layer?</summary>
	public bool bUseSingleLayer;
	///<summary>The tile map used by this component</summary>
	public UPaperTileMap TileMap;
	///<summary>Should this component show a tile grid when the component is selected?</summary>
	public bool bShowPerTileGridWhenSelected;
	///<summary>Should this component show an outline around each layer when the component is selected?</summary>
	public bool bShowPerLayerGridWhenSelected;
	///<summary>Should this component show an outline around the first layer when the component is not selected?</summary>
	public bool bShowOutlineWhenUnselected;
	///<summary>Should this component show a tile grid when the component is not selected?</summary>
	public bool bShowPerTileGridWhenUnselected;
	///<summary>Should this component show an outline around each layer when the component is not selected?</summary>
	public bool bShowPerLayerGridWhenUnselected;
	///<summary>Creates a new tile map of the specified size, replacing the TileMap reference (or dropping the previous owned one)</summary>
	public  void CreateNewTileMap(int MapWidth/*=4*/,int MapHeight/*=4*/,int TileWidth/*=32*/,int TileHeight/*=32*/,float PixelsPerUnrealUnit/*=1.0f*/,bool bCreateLayer/*=true*/) {}
	///<summary>Does this component own the tile map (is it instanced instead of being an asset reference)?</summary>
	public  bool OwnsTileMap() { return default; }
	///<summary>Change the PaperTileMap used by this instance.</summary>
	public  bool SetTileMap(UPaperTileMap NewTileMap) { return default; }
	///<summary>Returns the size of the tile map</summary>
	public  void GetMapSize(int MapWidth,int MapHeight,int NumLayers) {}
	///<summary>Returns the contents of a specified tile cell</summary>
	public  FPaperTileInfo GetTile(int X,int Y,int Layer) { return default; }
	///<summary>Modifies the contents of a specified tile cell (Note: This will only work on components that own their own tile map (OwnsTileMap returns true), you cannot modify standalone tile map assets)</summary>
	public  void SetTile(int X,int Y,int Layer,FPaperTileInfo NewValue) {}
	///<summary>Resizes the tile map (Note: This will only work on components that own their own tile map (OwnsTileMap returns true), you cannot modify standalone tile map assets)</summary>
	public  void ResizeMap(int NewWidthInTiles,int NewHeightInTiles) {}
	///<summary>Creates and adds a new layer to the tile map</summary>
	public  UPaperTileLayer AddNewLayer() { return default; }
	///<summary>Gets the tile map global color multiplier (multiplied with the per-layer color and passed to the material as a vertex color)</summary>
	public  FLinearColor GetTileMapColor() { return default; }
	///<summary>Sets the tile map global color multiplier (multiplied with the per-layer color and passed to the material as a vertex color)</summary>
	public  void SetTileMapColor(FLinearColor NewColor) {}
	///<summary>Gets the per-layer color multiplier for a specific layer (multiplied with the tile map color and passed to the material as a vertex color)</summary>
	public  FLinearColor GetLayerColor(int Layer/*=0*/) { return default; }
	///<summary>Sets the per-layer color multiplier for a specific layer (multiplied with the tile map color and passed to the material as a vertex color)</summary>
	public  void SetLayerColor(FLinearColor NewColor,int Layer/*=0*/) {}
	///<summary>Makes the tile map asset pointed to by this component editable.  Nothing happens if it was already instanced, but</summary>
	public  void MakeTileMapEditable() {}
	///<summary>Returns the position of the top left corner of the specified tile</summary>
	public  FVector GetTileCornerPosition(int TileX,int TileY,int LayerIndex/*=0*/,bool bWorldSpace/*=false*/) { return default; }
	///<summary>Returns the position of the center of the specified tile</summary>
	public  FVector GetTileCenterPosition(int TileX,int TileY,int LayerIndex/*=0*/,bool bWorldSpace/*=false*/) { return default; }
	///<summary>Returns the polygon for the specified tile (will be 4 or 6 vertices as a rectangle, diamond, or hexagon)</summary>
	public  void GetTilePolygon(int TileX,int TileY,TArray<FVector> Points,int LayerIndex/*=0*/,bool bWorldSpace/*=false*/) {}
	///<summary>Sets the default thickness for any layers that don&#39;t override the collision thickness</summary>
	public  void SetDefaultCollisionThickness(float Thickness,bool bRebuildCollision/*=true*/) {}
	///<summary>Sets the collision thickness for a specific layer</summary>
	public  void SetLayerCollision(int Layer/*=0*/,bool bHasCollision/*=true*/,bool bOverrideThickness/*=true*/,float CustomThickness/*=50.0f*/,bool bOverrideOffset/*=false*/,float CustomOffset/*=0.0f*/,bool bRebuildCollision/*=true*/) {}
	///<summary>Rebuilds collision for the tile map</summary>
	public  void RebuildCollision() {}
}
