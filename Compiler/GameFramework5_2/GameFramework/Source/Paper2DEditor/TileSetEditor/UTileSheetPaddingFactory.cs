#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TileSetEditor/TileSheetPaddingFactory.h")]
///<summary>Factory used to pad out each individual tile in a tile sheet texture</summary>
public partial class UTileSheetPaddingFactory : UFactory {
// TileSheetPaddingFactory
	public UPaperTileSet SourceTileSet;
	public int ExtrusionAmount;
	public bool bPadToPowerOf2;
	public bool bFillWithTransparentBlack;
}
