#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncActionLoadPrimaryAsset.h")]
public partial class UAsyncActionLoadPrimaryAssetClass : UAsyncActionLoadPrimaryAssetBase {
	public static UClass StaticClass() {return default;}
	///<summary>Load a primary asset class  into memory, this will cause it to stay loaded until it is explicitly unloaded.</summary>
	public static UAsyncActionLoadPrimaryAssetClass AsyncLoadPrimaryAssetClass(UObject WorldContextObject,FPrimaryAssetId PrimaryAsset,TArray<string> LoadBundles) { return default; }
	///<summary>Completed</summary>
	public FOnPrimaryAssetClassLoaded Completed;
}
