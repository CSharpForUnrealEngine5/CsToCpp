namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataFilter.h")]
///<summary>Flags controlling which item categories should be included</summary>
public enum EContentBrowserItemCategoryFilter {
	IncludeNone=0,
	IncludeAssets=-1,
	IncludeClasses=-1,
	IncludeCollections=-1,
	IncludeMisc=-1,
	IncludeAll=-1,
}
