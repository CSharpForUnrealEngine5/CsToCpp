#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncActionLoadPrimaryAsset.h")]
public partial class UAsyncActionLoadPrimaryAssetClassList : UAsyncActionLoadPrimaryAssetBase {
	///<summary>Load a list of primary asset classes into memory, this will cause them to stay loaded until explicitly unloaded.</summary>
	public static UAsyncActionLoadPrimaryAssetClassList AsyncLoadPrimaryAssetClassList(UObject WorldContextObject,TArray<FPrimaryAssetId> PrimaryAssetList,TArray<string> LoadBundles) { return default; }
	///<summary>Completed</summary>
	public FOnPrimaryAssetClassListLoaded Completed;
}
