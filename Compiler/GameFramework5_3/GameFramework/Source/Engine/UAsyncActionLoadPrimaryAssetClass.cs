namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncActionLoadPrimaryAsset.h")]
public partial class UAsyncActionLoadPrimaryAssetClass : UAsyncActionLoadPrimaryAssetBase {
	public static UClass StaticClass() {return default;}
	///<summary>Load a primary asset class  into memory, this will cause it to stay loaded until it is explicitly unloaded.</summary>
	public static UAsyncActionLoadPrimaryAssetClass AsyncLoadPrimaryAssetClass(UObject WorldContextObject,FPrimaryAssetId PrimaryAsset,TArray<FName> LoadBundles) { return default; }
	///<summary>Completed</summary>
	public FOnPrimaryAssetClassLoaded Completed;
}
