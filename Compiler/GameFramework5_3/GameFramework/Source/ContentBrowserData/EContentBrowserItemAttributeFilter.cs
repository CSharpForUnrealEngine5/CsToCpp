namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataFilter.h")]
///<summary>Flags controlling which item attributes should be included</summary>
public enum EContentBrowserItemAttributeFilter {
	IncludeNone=0,
	IncludeProject=-1,
	IncludeEngine=-1,
	IncludePlugins=-1,
	IncludeDeveloper=-1,
	IncludeLocalized=-1,
	IncludeAll=-1,
}
