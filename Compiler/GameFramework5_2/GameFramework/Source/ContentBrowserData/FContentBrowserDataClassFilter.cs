namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data used to filter object instances by their class.</summary>
[CppInclude("ContentBrowserDataFilter.h")]
public partial struct FContentBrowserDataClassFilter {
	public TArray<string> ClassNamesToInclude;
	public TArray<string> ClassNamesToExclude;
	public bool bRecursiveClassNamesToInclude;
	public bool bRecursiveClassNamesToExclude;
}
