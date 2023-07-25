#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetRegistry/AssetRegistryHelpers.h")]
public partial class UAssetRegistryHelpers : UObject {
// AssetRegistryHelpers
	public object /*ReturnValue*/ GetAssetRegistry() { return default; }
	public FAssetData CreateAssetData(UObject InAsset,bool bAllowBlueprintClass/*=false*/) { return default; }
	public bool IsValid(FAssetData InAssetData) { return default; }
	public bool IsUAsset(FAssetData InAssetData) { return default; }
	public bool IsRedirector(FAssetData InAssetData) { return default; }
	public string GetFullName(FAssetData InAssetData) { return default; }
	public FSoftObjectPath ToSoftObjectPath(FAssetData InAssetData) { return default; }
	public UClass GetClass(FAssetData InAssetData) { return default; }
	public UObject GetAsset(FAssetData InAssetData) { return default; }
	public bool IsAssetLoaded(FAssetData InAssetData) { return default; }
	public string GetExportTextName(FAssetData InAssetData) { return default; }
	public bool GetTagValue(FAssetData InAssetData,string InTagName,string OutTagValue) { return default; }
	public FARFilter SetFilterTagsAndValues(FARFilter InFilter,TArray<FTagAndValue> InTagsAndValues) { return default; }
	public void GetBlueprintAssets(FARFilter InFilter,TArray<FAssetData> OutAssetData) {}
	public UClass FindAssetNativeClass(FAssetData AssetData) { return default; }
}
