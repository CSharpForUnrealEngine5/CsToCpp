#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserItemPath.h")]
public partial class UContentBrowserItemPathExtensions : UBlueprintFunctionLibrary {
// ContentBrowserItemPathExtensions
	public static void SetPath(FContentBrowserItemPath ItemPath,string InPath,EContentBrowserPathType InPathType) {}
	public static string GetVirtualPath(FContentBrowserItemPath ItemPath) { return default; }
	public static string GetInternalPath(FContentBrowserItemPath ItemPath) { return default; }
	public static FContentBrowserItemPath MakeContentBrowserItemPath(string InPath,EContentBrowserPathType InPathType) { return default; }
	public static void BreakContentBrowserItemPath(FContentBrowserItemPath ItemPath,string VirtualPath,string InternalPath) {}
}
