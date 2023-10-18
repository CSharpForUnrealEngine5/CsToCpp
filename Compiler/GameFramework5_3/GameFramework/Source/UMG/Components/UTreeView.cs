namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Similar to ListView, but can display a hierarchical tree of elements.</summary>
[CppInclude("Components/TreeView.h")]
public partial class UTreeView : UListView {
	public static UClass StaticClass() {return default;}
	///<summary>Attempts to expand/collapse the given item (only relevant if the item has children)</summary>
	public void SetItemExpansion(UObject Item,bool bExpandItem) {}
	///<summary>Expands all items with children</summary>
	public void ExpandAll() {}
	///<summary>Collapses all currently expanded items</summary>
	public void CollapseAll() {}
	///<summary>Called to get the list of children (if any) that correspond to the given item. Only called if the native C++ version of the event is not bound.</summary>
	public FOnGetItemChildrenDynamic BP_OnGetItemChildren;
	///<summary>BP_OnItemExpansionChanged</summary>
	public FOnItemExpansionChangedDynamic BP_OnItemExpansionChanged;
}
