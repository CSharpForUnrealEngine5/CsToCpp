namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataMenuContexts.h")]
public partial class UContentBrowserDataMenuContext_FileMenu : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SelectedItems</summary>
	public TArray<FContentBrowserItem> SelectedItems;
	///<summary>bCanBeModified</summary>
	public bool bCanBeModified;
	///<summary>bHasCookedPackages</summary>
	public bool bHasCookedPackages;
	///<summary>bContainsUnsupportedAssets</summary>
	public bool bContainsUnsupportedAssets;
}
