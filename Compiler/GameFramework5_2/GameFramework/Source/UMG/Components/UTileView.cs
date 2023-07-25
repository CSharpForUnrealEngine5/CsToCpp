#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TileView.h")]
///<summary>A ListView that presents the contents as a set of tiles all uniformly sized.</summary>
public partial class UTileView : UListView {
// TileView
	public void SetEntryHeight(float NewHeight) {}
	public void SetEntryWidth(float NewWidth) {}
	public float GetEntryHeight() { return default; }
	public float GetEntryWidth() { return default; }
	public float EntryHeight;
	public float EntryWidth;
	public EListItemAlignment TileAlignment;
	public bool bWrapHorizontalNavigation;
}
