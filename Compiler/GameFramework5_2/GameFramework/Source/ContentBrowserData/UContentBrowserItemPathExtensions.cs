#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserItemPath.h")]
public partial class UContentBrowserItemPathExtensions : UBlueprintFunctionLibrary {
// ContentBrowserItemPathExtensions
	public void SetPath(FContentBrowserItemPath ItemPath,string InPath,EContentBrowserPathType InPathType) {}
	public string GetVirtualPath(FContentBrowserItemPath ItemPath) { return default; }
	public string GetInternalPath(FContentBrowserItemPath ItemPath) { return default; }
	public FContentBrowserItemPath MakeContentBrowserItemPath(string InPath,EContentBrowserPathType InPathType) { return default; }
	public void BreakContentBrowserItemPath(FContentBrowserItemPath ItemPath,string VirtualPath,string InternalPath) {}
}
