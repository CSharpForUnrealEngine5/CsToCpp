#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
