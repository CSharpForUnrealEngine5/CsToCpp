#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class represents a single layer in a tile map.  All layers in the map must have the size dimensions.</summary>
[CppInclude("PaperTileLayer.h")]
public partial class UPaperTileLayer : UObject {
	///<summary>Name of the layer</summary>
	public string LayerName;
	///<summary>Width of the layer (in tiles)</summary>
	public int LayerWidth;
	///<summary>Height of the layer (in tiles)</summary>
	public int LayerHeight;
	///<summary>Is this layer currently hidden in the editor?</summary>
	public bool bHiddenInEditor;
	///<summary>Should this layer be hidden in the game?</summary>
	public bool bHiddenInGame;
	///<summary>Should this layer generate collision?</summary>
	public bool bLayerCollides;
	///<summary>Should this layer use a custom thickness for generated collision instead of the thickness setting in the tile map?</summary>
	public bool bOverrideCollisionThickness;
	///<summary>Should this layer use a custom offset for generated collision instead of the layer drawing offset?</summary>
	public bool bOverrideCollisionOffset;
	///<summary>The override thickness of the collision for this layer (when bOverrideCollisionThickness is set)</summary>
	public float CollisionThicknessOverride;
	///<summary>The override offset of the collision for this layer (when bOverrideCollisionOffset is set)</summary>
	public float CollisionOffsetOverride;
	///<summary>The color of this layer (multiplied with the tile map color and passed to the material as a vertex color)</summary>
	public FLinearColor LayerColor;
	///<summary>The allocated width of the tile data (used to handle resizing without data loss)</summary>
	public int AllocatedWidth;
	///<summary>The allocated height of the tile data (used to handle resizing without data loss)</summary>
	public int AllocatedHeight;
	///<summary>The allocated tile data</summary>
	public TArray<FPaperTileInfo> AllocatedCells;
	///<summary>TileSet_DEPRECATED</summary>
	public UPaperTileSet TileSet_DEPRECATED;
	///<summary>AllocatedGrid_DEPRECATED</summary>
	public TArray<int> AllocatedGrid_DEPRECATED;
}
