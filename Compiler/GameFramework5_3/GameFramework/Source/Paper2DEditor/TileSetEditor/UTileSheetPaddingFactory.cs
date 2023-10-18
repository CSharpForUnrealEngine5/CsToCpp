namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory used to pad out each individual tile in a tile sheet texture</summary>
[CppInclude("TileSetEditor/TileSheetPaddingFactory.h")]
public partial class UTileSheetPaddingFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Source tile sheet texture</summary>
	public UPaperTileSet SourceTileSet;
	///<summary>The amount to extrude out from each tile (in pixels)</summary>
	public int ExtrusionAmount;
	///<summary>Should we pad the texture to the next power of 2?</summary>
	public bool bPadToPowerOf2;
	///<summary>Should we use transparent black or white when filling the texture areas that aren&#39;t covered by tiles?</summary>
	public bool bFillWithTransparentBlack;
}
