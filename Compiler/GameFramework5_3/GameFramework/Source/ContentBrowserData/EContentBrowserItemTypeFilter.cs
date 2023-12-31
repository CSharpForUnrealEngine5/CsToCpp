namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataFilter.h")]
///<summary>Flags controlling which item types should be included</summary>
public enum EContentBrowserItemTypeFilter {
	IncludeNone=0,
	IncludeFolders=-1,
	IncludeFiles=-1,
	IncludeAll=-1,
}
