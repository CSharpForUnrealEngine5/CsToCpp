#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCAssetFilter {
	public TArray<string> PackageNames;
	public TArray<string> PackagePaths;
	public TArray<string> ClassNames;
	public TSet<string> RecursiveClassesExclusionSet;
	public TArray<string> NativeParentClasses;
	public bool RecursiveClasses;
	public bool RecursivePaths;
	public bool EnableBlueprintNativeClassFiltering;
}
