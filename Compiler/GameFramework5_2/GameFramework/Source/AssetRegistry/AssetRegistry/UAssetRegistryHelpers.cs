#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetRegistry/AssetRegistryHelpers.h")]
public partial class UAssetRegistryHelpers : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetAssetRegistry</summary>
	public static object /*ReturnValue*/ GetAssetRegistry() { return default; }
	///<summary>Creates asset data from a UObject.</summary>
	public static FAssetData CreateAssetData(UObject InAsset,bool bAllowBlueprintClass/*=false*/) { return default; }
	///<summary>Checks to see if this AssetData refers to an asset or is NULL</summary>
	public static bool IsValid(FAssetData InAssetData) { return default; }
	///<summary>Returns true if this is the primary asset in a package, true for maps and assets but false for secondary objects like class redirectors</summary>
	public static bool IsUAsset(FAssetData InAssetData) { return default; }
	///<summary>Returns true if the this asset is a redirector.</summary>
	public static bool IsRedirector(FAssetData InAssetData) { return default; }
	///<summary>Returns the full name for the asset in the form: Class ObjectPath</summary>
	public static string GetFullName(FAssetData InAssetData) { return default; }
	///<summary>Convert to a SoftObjectPath for loading</summary>
	public static FSoftObjectPath ToSoftObjectPath(FAssetData InAssetData) { return default; }
	///<summary>GetClass</summary>
	public static UClass GetClass(FAssetData InAssetData) { return default; }
	///<summary>Returns the asset UObject if it is loaded or loads the asset if it is unloaded then returns the result</summary>
	public static UObject GetAsset(FAssetData InAssetData) { return default; }
	///<summary>Returns true if the asset is loaded</summary>
	public static bool IsAssetLoaded(FAssetData InAssetData) { return default; }
	///<summary>Returns the name for the asset in the form: Class&#39;ObjectPath&#39;</summary>
	public static string GetExportTextName(FAssetData InAssetData) { return default; }
	///<summary>Gets the value associated with the given tag as a string</summary>
	public static bool GetTagValue(FAssetData InAssetData,string InTagName,string OutTagValue) { return default; }
	///<summary>Populates the FARFilters tags and values map with the passed in tags and values</summary>
	public static FARFilter SetFilterTagsAndValues(FARFilter InFilter,TArray<FTagAndValue> InTagsAndValues) { return default; }
	///<summary>Gets asset data for all blueprint assets that match the filter. ClassPaths in the filter specify the blueprint&#39;s parent class.</summary>
	public static void GetBlueprintAssets(FARFilter InFilter,TArray<FAssetData> OutAssetData) {}
	///<summary>Returns the first native class of the asset type that can be found.  Normally this is just the FAssetData::GetClass(),</summary>
	public static UClass FindAssetNativeClass(FAssetData AssetData) { return default; }
}
