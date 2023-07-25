#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncActionLoadPrimaryAsset.h")]
public partial class UAsyncActionChangePrimaryAssetBundles : UAsyncActionLoadPrimaryAssetBase {
// AsyncActionChangePrimaryAssetBundles
	public UObject AsyncChangeBundleStateForMatchingPrimaryAssets(UObject WorldContextObject,TArray<string> NewBundles,TArray<string> OldBundles) { return default; }
	public UObject AsyncChangeBundleStateForPrimaryAssetList(UObject WorldContextObject,TArray<FPrimaryAssetId> PrimaryAssetList,TArray<string> AddBundles,TArray<string> RemoveBundles) { return default; }
	public FOnPrimaryAssetBundlesChanged Completed;
}
