#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>A struct to serve as a filter for Asset Registry queries. (mirrored in ARFilter.h)</summary>
public partial struct FARFilter {
// ARFilter
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
