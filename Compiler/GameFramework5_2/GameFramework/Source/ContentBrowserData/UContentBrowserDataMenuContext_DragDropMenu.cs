namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataMenuContexts.h")]
public partial class UContentBrowserDataMenuContext_DragDropMenu : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DropTargetItem</summary>
	public FContentBrowserItem DropTargetItem;
	///<summary>DraggedItems</summary>
	public TArray<FContentBrowserItem> DraggedItems;
	///<summary>bCanMove</summary>
	public bool bCanMove;
	///<summary>bCanCopy</summary>
	public bool bCanCopy;
}
