#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetRegistry/AssetRegistryHelpers.h")]
public partial class UAssetRegistryHelpers : UObject {
// AssetRegistryHelpers
	public static object /*ReturnValue*/ GetAssetRegistry() { return default; }
	public static FAssetData CreateAssetData(UObject InAsset,bool bAllowBlueprintClass/*=false*/) { return default; }
	public static bool IsValid(FAssetData InAssetData) { return default; }
	public static bool IsUAsset(FAssetData InAssetData) { return default; }
	public static bool IsRedirector(FAssetData InAssetData) { return default; }
	public static string GetFullName(FAssetData InAssetData) { return default; }
	public static FSoftObjectPath ToSoftObjectPath(FAssetData InAssetData) { return default; }
	public static UClass GetClass(FAssetData InAssetData) { return default; }
	public static UObject GetAsset(FAssetData InAssetData) { return default; }
	public static bool IsAssetLoaded(FAssetData InAssetData) { return default; }
	public static string GetExportTextName(FAssetData InAssetData) { return default; }
	public static bool GetTagValue(FAssetData InAssetData,string InTagName,string OutTagValue) { return default; }
	public static FARFilter SetFilterTagsAndValues(FARFilter InFilter,TArray<FTagAndValue> InTagsAndValues) { return default; }
	public static void GetBlueprintAssets(FARFilter InFilter,TArray<FAssetData> OutAssetData) {}
	public static UClass FindAssetNativeClass(FAssetData AssetData) { return default; }
}
