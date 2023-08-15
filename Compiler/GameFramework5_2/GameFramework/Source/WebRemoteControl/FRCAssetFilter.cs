namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCAssetFilter {
	public TArray<FName> PackageNames;
	public TArray<FName> PackagePaths;
	public TArray<FName> ClassNames;
	public TSet<FName> RecursiveClassesExclusionSet;
	public TArray<FName> NativeParentClasses;
	public bool RecursiveClasses;
	public bool RecursivePaths;
	public bool EnableBlueprintNativeClassFiltering;
}
