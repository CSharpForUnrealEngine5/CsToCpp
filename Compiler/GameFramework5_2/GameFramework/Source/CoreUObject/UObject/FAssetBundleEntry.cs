#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FAssetBundleEntry {
// AssetBundleEntry
	public string BundleName;
	public TArray<FSoftObjectPath> BundleAssets;
	public TArray<FTopLevelAssetPath> AssetPaths;
}
