namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncActionLoadPrimaryAsset.h")]
public partial class UAsyncActionLoadPrimaryAssetList : UAsyncActionLoadPrimaryAssetBase {
	public static UClass StaticClass() {return default;}
	///<summary>Load a list of primary asset objects into memory, this will cause them to stay loaded until explicitly unloaded.</summary>
	public static UAsyncActionLoadPrimaryAssetList AsyncLoadPrimaryAssetList(UObject WorldContextObject,TArray<FPrimaryAssetId> PrimaryAssetList,TArray<FName> LoadBundles) { return default; }
	///<summary>Completed</summary>
	public FOnPrimaryAssetListLoaded Completed;
}
