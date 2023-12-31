namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FAssetBundleEntry {
	public FName BundleName;
	public TArray<FSoftObjectPath> BundleAssets;
	public TArray<FTopLevelAssetPath> AssetPaths;
}
