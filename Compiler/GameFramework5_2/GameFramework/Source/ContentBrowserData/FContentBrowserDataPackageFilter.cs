#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataFilter.h")]
///<summary>Data used to filter object instances by their package.</summary>
public partial struct FContentBrowserDataPackageFilter {
// ContentBrowserDataPackageFilter
	public TArray<string> PackageNamesToInclude;
	public TArray<string> PackageNamesToExclude;
	public TArray<string> PackagePathsToInclude;
	public TArray<string> PackagePathsToExclude;
	public bool bRecursivePackagePathsToInclude;
	public bool bRecursivePackagePathsToExclude;
}
