namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A ListView that presents the contents as a set of tiles all uniformly sized.</summary>
[CppInclude("Components/TileView.h")]
public partial class UTileView : UListView {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the height of every tile entry</summary>
	public void SetEntryHeight(float NewHeight) {}
	///<summary>Sets the width of every tile entry</summary>
	public void SetEntryWidth(float NewWidth) {}
	///<summary>Gets the height of tile entries</summary>
	public float GetEntryHeight() { return default; }
	///<summary>Gets the width of tile entries</summary>
	public float GetEntryWidth() { return default; }
	///<summary>The height of each tile</summary>
	public float EntryHeight;
	///<summary>The width of each tile</summary>
	public float EntryWidth;
	///<summary>The method by which to align the tile entries in the available space for the tile view</summary>
	public EListItemAlignment TileAlignment;
	///<summary>True to allow left/right navigation to wrap back to the tile on the opposite edge</summary>
	public bool bWrapHorizontalNavigation;
}
