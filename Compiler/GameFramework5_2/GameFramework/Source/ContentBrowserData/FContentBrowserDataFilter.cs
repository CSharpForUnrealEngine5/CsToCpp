#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataFilter.h")]
///<summary>A filter used to control what is returned from Content Browser data queries.</summary>
public partial struct FContentBrowserDataFilter {
// ContentBrowserDataFilter
	public bool bRecursivePaths;
	public EContentBrowserItemTypeFilter ItemTypeFilter;
	public EContentBrowserItemCategoryFilter ItemCategoryFilter;
	public EContentBrowserItemAttributeFilter ItemAttributeFilter;
}
