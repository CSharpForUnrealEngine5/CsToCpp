namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A DataAsset that implements GetPrimaryAssetId and has asset bundle support, which allows it to be manually loaded/unloaded from the AssetManager.</summary>
[CppInclude("Engine/DataAsset.h")]
public partial class UPrimaryDataAsset : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Asset Bundle data computed at save time. In cooked builds this is accessible from AssetRegistry</summary>
	public FAssetBundleData AssetBundleData;
}
