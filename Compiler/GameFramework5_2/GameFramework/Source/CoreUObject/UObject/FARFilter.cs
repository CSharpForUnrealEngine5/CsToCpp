namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A struct to serve as a filter for Asset Registry queries. (mirrored in ARFilter.h)</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FARFilter {
	public TArray<FName> PackageNames;
	public TArray<FName> PackagePaths;
	public TArray<FName> ObjectPaths;
	public TArray<FSoftObjectPath> SoftObjectPaths;
	public TArray<FName> ClassNames;
	public TArray<FTopLevelAssetPath> ClassPaths;
	public TSet<FName> RecursiveClassesExclusionSet;
	public TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet;
	public bool bRecursivePaths;
	public bool bRecursiveClasses;
	public bool bIncludeOnlyOnDiskAssets;
}
