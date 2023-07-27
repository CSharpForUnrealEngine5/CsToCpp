#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TreeView.h")]
///<summary>Similar to ListView, but can display a hierarchical tree of elements.</summary>
public partial class UTreeView : UListView {
// TreeView
	public  void SetItemExpansion(UObject Item,bool bExpandItem) {}
	public  void ExpandAll() {}
	public  void CollapseAll() {}
	public FOnGetItemChildrenDynamic BP_OnGetItemChildren;
	public FOnItemExpansionChangedDynamic BP_OnItemExpansionChanged;
}
