namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Paper2D tile map editor</summary>
[CppInclude("TileMapEditing/TileMapEditorSettings.h")]
public partial class UTileMapEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Default background color for new tile map assets</summary>
	public FColor DefaultBackgroundColor;
	///<summary>Should the grid be shown by default when the editor is opened?</summary>
	public bool bShowGridByDefault;
	///<summary>Default per tile grid color for new tile map assets</summary>
	public FColor DefaultTileGridColor;
	///<summary>Default multi tile grid color for new tile map assets</summary>
	public FColor DefaultMultiTileGridColor;
	///<summary>Default number of tiles the multi tile grid spans horizontally for new tile map assets. 0 removes vertical lines</summary>
	public int DefaultMultiTileGridWidth;
	///<summary>Default number of tiles the multi tile grid spans vertically for new tile map assets. 0 removes horizontal lines</summary>
	public int DefaultMultiTileGridHeight;
	///<summary>Default number of tiles the multi tile grid is shifted to the right for new tile map assets</summary>
	public int DefaultMultiTileGridOffsetX;
	///<summary>Default number of tiles the multi tile grid is shifted downwards for new tile map assets</summary>
	public int DefaultMultiTileGridOffsetY;
	///<summary>Default layer grid color for new tile map assets</summary>
	public FColor DefaultLayerGridColor;
}
