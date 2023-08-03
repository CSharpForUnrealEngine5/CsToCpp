#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Paper2D tile set editor</summary>
[CppInclude("TileSetEditor/TileSetEditorSettings.h")]
public partial class UTileSetEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Default background color for new tile set assets</summary>
	public FColor DefaultBackgroundColor;
	///<summary>Should the grid be shown by default when the editor is opened?</summary>
	public bool bShowGridByDefault;
	///<summary>The amount to extrude out from the edge of each tile (in pixels)</summary>
	public int ExtrusionAmount;
	///<summary>Should we pad the conditioned texture to the next power of 2?</summary>
	public bool bPadToPowerOf2;
	///<summary>Should we use transparent black or white when filling the texture areas that aren&#39;t covered by tiles?</summary>
	public bool bFillWithTransparentBlack;
}
