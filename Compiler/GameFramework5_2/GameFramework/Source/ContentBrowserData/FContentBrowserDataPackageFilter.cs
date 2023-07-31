#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data used to filter object instances by their package.</summary>
[CppInclude("ContentBrowserDataFilter.h")]
public partial struct FContentBrowserDataPackageFilter {
	public TArray<string> PackageNamesToInclude;
	public TArray<string> PackageNamesToExclude;
	public TArray<string> PackagePathsToInclude;
	public TArray<string> PackagePathsToExclude;
	public bool bRecursivePackagePathsToInclude;
	public bool bRecursivePackagePathsToExclude;
}
