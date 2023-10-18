namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This library&#39;s purpose is to facilitate Blueprints to discover assets using some filters and sort them.</summary>
[CppInclude("FunctionLibraries/AssetFilteringAndSortingFunctionLibrary.h")]
public partial class UAssetFilteringAndSortingFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Gets all assets which have the given tags.</summary>
	public static TArray<FAssetData> GetAllAssetsByMetaDataTags(TSet<FName> RequiredTags,TSet<UClass> AllowedClasses) { return default; }
	///<summary>Sorts the assets based on a custom Blueprint delegate.</summary>
	public static void SortByCustomPredicate(TArray<FAssetData> Assets,FAssetSortingPredicate SortingPredicate,ESortOrder SortOrder/*=ESortOrder.Ascending*/) {}
	///<summary>Sorts the assets by their asset name.</summary>
	public static void SortByAssetName(TArray<FAssetData> Assets,ESortOrder SortOrder/*=ESortOrder.Ascending*/) {}
	///<summary>Sorts the assets based on their meta data&#39;s type.</summary>
	public static bool SortByMetaData(TArray<FAssetData> Assets,FName MetaDataTag,EAssetTagMetaDataSortType MetaDataType,ESortOrder SortOrder/*=ESortOrder.Ascending*/) { return default; }
}
