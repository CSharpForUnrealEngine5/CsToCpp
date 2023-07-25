#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/DataAsset.h")]
///<summary>A DataAsset that implements GetPrimaryAssetId and has asset bundle support, which allows it to be manually loaded/unloaded from the AssetManager.</summary>
public partial class UPrimaryDataAsset : UDataAsset {
// PrimaryDataAsset
	public FAssetBundleData AssetBundleData;
}
