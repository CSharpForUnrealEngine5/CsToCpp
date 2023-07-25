#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>A struct with a list of asset bundle entries. If one of these is inside a UObject it will get automatically exported as the asset registry tag AssetBundleData</summary>
public partial struct FAssetBundleData {
// AssetBundleData
	public TArray<FAssetBundleEntry> Bundles;
}
