namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data used to filter object instances by their name and tags.</summary>
[CppInclude("ContentBrowserDataFilter.h")]
public partial struct FContentBrowserDataObjectFilter {
	public TArray<string> ObjectNamesToInclude;
	public TArray<string> ObjectNamesToExclude;
	public bool bOnDiskObjectsOnly;
}
