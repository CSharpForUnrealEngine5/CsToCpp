#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncActionLoadPrimaryAsset.h")]
public partial class UAsyncActionChangePrimaryAssetBundles : UAsyncActionLoadPrimaryAssetBase {
	public static UClass StaticClass() {return default;}
	///<summary>Change the bundle state of all assets that match OldBundles to instead contain NewBundles.</summary>
	public static UAsyncActionChangePrimaryAssetBundles AsyncChangeBundleStateForMatchingPrimaryAssets(UObject WorldContextObject,TArray<string> NewBundles,TArray<string> OldBundles) { return default; }
	///<summary>Change the bundle state of specific assets in PrimaryAssetList.</summary>
	public static UAsyncActionChangePrimaryAssetBundles AsyncChangeBundleStateForPrimaryAssetList(UObject WorldContextObject,TArray<FPrimaryAssetId> PrimaryAssetList,TArray<string> AddBundles,TArray<string> RemoveBundles) { return default; }
	///<summary>Completed</summary>
	public FOnPrimaryAssetBundlesChanged Completed;
}
