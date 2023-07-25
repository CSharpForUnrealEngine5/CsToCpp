#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperTileLayer.h")]
///<summary>This class represents a single layer in a tile map.  All layers in the map must have the size dimensions.</summary>
public partial class UPaperTileLayer : UObject {
// PaperTileLayer
	public string LayerName;
	public int LayerWidth;
	public int LayerHeight;
	public bool bHiddenInEditor;
	public bool bHiddenInGame;
	public bool bLayerCollides;
	public bool bOverrideCollisionThickness;
	public bool bOverrideCollisionOffset;
	public float CollisionThicknessOverride;
	public float CollisionOffsetOverride;
	public FLinearColor LayerColor;
	public int AllocatedWidth;
	public int AllocatedHeight;
	public TArray<FPaperTileInfo> AllocatedCells;
	public UPaperTileSet TileSet_DEPRECATED;
	public TArray<int> AllocatedGrid_DEPRECATED;
}
