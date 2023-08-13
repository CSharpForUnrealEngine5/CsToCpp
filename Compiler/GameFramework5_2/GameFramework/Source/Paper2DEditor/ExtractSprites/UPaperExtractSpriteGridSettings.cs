namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtractSprites/PaperExtractSpritesSettings.h")]
public partial class UPaperExtractSpriteGridSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The width of each sprite in grid mode</summary>
	public int CellWidth;
	///<summary>The height of each sprite in grid mode</summary>
	public int CellHeight;
	///<summary>Number of cells extracted horizontally. Can be used to limit the number of sprites extracted. Set to 0 to extract all sprites</summary>
	public int NumCellsX;
	///<summary>Number of cells extracted vertically. Can be used to limit the number of sprites extracted. Set to 0 to extract all sprites</summary>
	public int NumCellsY;
	///<summary>Margin from the left of the texture to the first sprite</summary>
	public int MarginX;
	///<summary>Margin from the top of the texture to the first sprite</summary>
	public int MarginY;
	///<summary>Horizontal spacing between sprites</summary>
	public int SpacingX;
	///<summary>Vertical spacing between sprites</summary>
	public int SpacingY;
}
