namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A struct with a list of asset bundle entries. If one of these is inside a UObject it will get automatically exported as the asset registry tag AssetBundleData</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FAssetBundleData {
	public TArray<FAssetBundleEntry> Bundles;
}
