namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserItemPath.h")]
public partial class UContentBrowserItemPathExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Set the path being stored</summary>
	public static void SetPath(FContentBrowserItemPath ItemPath,FName InPath,EContentBrowserPathType InPathType) {}
	///<summary>Returns virtual path as FName (eg, &quot;/All/Plugins/PluginA/MyFile&quot;).</summary>
	public static FName GetVirtualPath(FContentBrowserItemPath ItemPath) { return default; }
	///<summary>Returns internal path if there is one (eg,. &quot;/PluginA/MyFile&quot;).</summary>
	public static FName GetInternalPath(FContentBrowserItemPath ItemPath) { return default; }
	///<summary>MakeContentBrowserItemPath</summary>
	public static FContentBrowserItemPath MakeContentBrowserItemPath(FName InPath,EContentBrowserPathType InPathType) { return default; }
	///<summary>BreakContentBrowserItemPath</summary>
	public static void BreakContentBrowserItemPath(FContentBrowserItemPath ItemPath,FName VirtualPath,FName InternalPath) {}
}
