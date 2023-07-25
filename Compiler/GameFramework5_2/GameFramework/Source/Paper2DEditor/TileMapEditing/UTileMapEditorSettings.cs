#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TileMapEditing/TileMapEditorSettings.h")]
///<summary>Settings for the Paper2D tile map editor</summary>
public partial class UTileMapEditorSettings : UObject {
// TileMapEditorSettings
	public FColor DefaultBackgroundColor;
	public bool bShowGridByDefault;
	public FColor DefaultTileGridColor;
	public FColor DefaultMultiTileGridColor;
	public int DefaultMultiTileGridWidth;
	public int DefaultMultiTileGridHeight;
	public int DefaultMultiTileGridOffsetX;
	public int DefaultMultiTileGridOffsetY;
	public FColor DefaultLayerGridColor;
}
