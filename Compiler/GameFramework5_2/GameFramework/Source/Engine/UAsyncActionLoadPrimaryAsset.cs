namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncActionLoadPrimaryAsset.h")]
public partial class UAsyncActionLoadPrimaryAsset : UAsyncActionLoadPrimaryAssetBase {
	public static UClass StaticClass() {return default;}
	///<summary>Load a primary asset object into memory, this will cause it to stay loaded until it is explicitly unloaded.</summary>
	public static UAsyncActionLoadPrimaryAsset AsyncLoadPrimaryAsset(UObject WorldContextObject,FPrimaryAssetId PrimaryAsset,TArray<string> LoadBundles) { return default; }
	///<summary>Completed</summary>
	public FOnPrimaryAssetLoaded Completed;
}
