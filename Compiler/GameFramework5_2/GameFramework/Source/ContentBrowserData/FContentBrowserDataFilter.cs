#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A filter used to control what is returned from Content Browser data queries.</summary>
[CppInclude("ContentBrowserDataFilter.h")]
public partial struct FContentBrowserDataFilter {
	public bool bRecursivePaths;
	public EContentBrowserItemTypeFilter ItemTypeFilter;
	public EContentBrowserItemCategoryFilter ItemCategoryFilter;
	public EContentBrowserItemAttributeFilter ItemAttributeFilter;
}
