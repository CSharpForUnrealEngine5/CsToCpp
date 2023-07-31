#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A struct to serve as a filter for Asset Registry queries. (mirrored in ARFilter.h)</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FARFilter {
	public TArray<string> PackageNames;
	public TArray<string> PackagePaths;
	public TArray<string> ObjectPaths;
	public TArray<FSoftObjectPath> SoftObjectPaths;
	public TArray<string> ClassNames;
	public TArray<FTopLevelAssetPath> ClassPaths;
	public TSet<string> RecursiveClassesExclusionSet;
	public TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet;
	public bool bRecursivePaths;
	public bool bRecursiveClasses;
	public bool bIncludeOnlyOnDiskAssets;
}
