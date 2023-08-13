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
