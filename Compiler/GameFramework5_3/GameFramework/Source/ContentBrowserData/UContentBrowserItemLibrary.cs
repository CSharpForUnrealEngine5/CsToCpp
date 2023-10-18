namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TODO: Script API exposure</summary>
[CppInclude("ContentBrowserItem.h")]
public partial class UContentBrowserItemLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>IsFolder</summary>
	public static bool IsFolder(FContentBrowserItem Item) { return default; }
	///<summary>IsFile</summary>
	public static bool IsFile(FContentBrowserItem Item) { return default; }
	///<summary>GetVirtualPath</summary>
	public static FName GetVirtualPath(FContentBrowserItem Item) { return default; }
	///<summary>GetDisplayName</summary>
	public static FText GetDisplayName(FContentBrowserItem Item) { return default; }
}
