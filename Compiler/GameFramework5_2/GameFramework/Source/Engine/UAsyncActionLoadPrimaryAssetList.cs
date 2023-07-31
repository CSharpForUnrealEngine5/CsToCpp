#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncActionLoadPrimaryAsset.h")]
public partial class UAsyncActionLoadPrimaryAssetList : UAsyncActionLoadPrimaryAssetBase {
	///<summary>Load a list of primary asset objects into memory, this will cause them to stay loaded until explicitly unloaded.</summary>
	public static UAsyncActionLoadPrimaryAssetList AsyncLoadPrimaryAssetList(UObject WorldContextObject,TArray<FPrimaryAssetId> PrimaryAssetList,TArray<string> LoadBundles) { return default; }
	///<summary>Completed</summary>
	public FOnPrimaryAssetListLoaded Completed;
}
