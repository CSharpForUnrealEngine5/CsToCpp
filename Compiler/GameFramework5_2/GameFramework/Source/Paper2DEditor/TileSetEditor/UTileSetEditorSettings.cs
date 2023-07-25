#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TileSetEditor/TileSetEditorSettings.h")]
///<summary>Settings for the Paper2D tile set editor</summary>
public partial class UTileSetEditorSettings : UObject {
// TileSetEditorSettings
	public FColor DefaultBackgroundColor;
	public bool bShowGridByDefault;
	public int ExtrusionAmount;
	public bool bPadToPowerOf2;
	public bool bFillWithTransparentBlack;
}
