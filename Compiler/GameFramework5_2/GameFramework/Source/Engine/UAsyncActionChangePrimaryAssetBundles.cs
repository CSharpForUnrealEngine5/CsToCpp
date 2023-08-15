namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncActionLoadPrimaryAsset.h")]
public partial class UAsyncActionChangePrimaryAssetBundles : UAsyncActionLoadPrimaryAssetBase {
	public static UClass StaticClass() {return default;}
	///<summary>Change the bundle state of all assets that match OldBundles to instead contain NewBundles.</summary>
	public static UAsyncActionChangePrimaryAssetBundles AsyncChangeBundleStateForMatchingPrimaryAssets(UObject WorldContextObject,TArray<FName> NewBundles,TArray<FName> OldBundles) { return default; }
	///<summary>Change the bundle state of specific assets in PrimaryAssetList.</summary>
	public static UAsyncActionChangePrimaryAssetBundles AsyncChangeBundleStateForPrimaryAssetList(UObject WorldContextObject,TArray<FPrimaryAssetId> PrimaryAssetList,TArray<FName> AddBundles,TArray<FName> RemoveBundles) { return default; }
	///<summary>Completed</summary>
	public FOnPrimaryAssetBundlesChanged Completed;
}
