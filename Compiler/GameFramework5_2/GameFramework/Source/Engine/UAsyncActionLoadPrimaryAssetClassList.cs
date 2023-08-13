namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncActionLoadPrimaryAsset.h")]
public partial class UAsyncActionLoadPrimaryAssetClassList : UAsyncActionLoadPrimaryAssetBase {
	public static UClass StaticClass() {return default;}
	///<summary>Load a list of primary asset classes into memory, this will cause them to stay loaded until explicitly unloaded.</summary>
	public static UAsyncActionLoadPrimaryAssetClassList AsyncLoadPrimaryAssetClassList(UObject WorldContextObject,TArray<FPrimaryAssetId> PrimaryAssetList,TArray<string> LoadBundles) { return default; }
	///<summary>Completed</summary>
	public FOnPrimaryAssetClassListLoaded Completed;
}
