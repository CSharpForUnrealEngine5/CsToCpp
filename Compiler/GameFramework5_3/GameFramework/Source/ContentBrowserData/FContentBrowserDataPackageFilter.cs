namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data used to filter object instances by their package.</summary>
[CppInclude("ContentBrowserDataFilter.h")]
public partial struct FContentBrowserDataPackageFilter {
	public TArray<FName> PackageNamesToInclude;
	public TArray<FName> PackageNamesToExclude;
	public TArray<FName> PackagePathsToInclude;
	public TArray<FName> PackagePathsToExclude;
	public bool bRecursivePackagePathsToInclude;
	public bool bRecursivePackagePathsToExclude;
}
