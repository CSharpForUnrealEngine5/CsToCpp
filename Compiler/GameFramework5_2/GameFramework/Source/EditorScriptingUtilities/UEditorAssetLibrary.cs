#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorAssetLibrary.h")]
///<summary>Utility class to do most of the common functionalities with the ContentBrowser.</summary>
public partial class UEditorAssetLibrary : UBlueprintFunctionLibrary {
// EditorAssetLibrary
	public static UObject LoadAsset(string AssetPath) { return default; }
	public static UClass LoadBlueprintClass(string AssetPath) { return default; }
	public static string GetPathNameForLoadedAsset(UObject LoadedAsset) { return default; }
	public static FAssetData FindAssetData(string AssetPath) { return default; }
	public static bool DoesAssetExist(string AssetPath) { return default; }
	public static bool DoAssetsExist(TArray<string> AssetPaths) { return default; }
	public static TArray<string> FindPackageReferencersForAsset(string AssetPath,bool bLoadAssetsToConfirm/*=false*/) { return default; }
	public static bool ConsolidateAssets(UObject AssetToConsolidateTo,TArray<UObject> AssetsToConsolidate) { return default; }
	public static bool DeleteLoadedAsset(UObject AssetToDelete) { return default; }
	public static bool DeleteLoadedAssets(TArray<UObject> AssetsToDelete) { return default; }
	public static bool DeleteAsset(string AssetPathToDelete) { return default; }
	public static bool DeleteDirectory(string DirectoryPath) { return default; }
	public static UObject DuplicateLoadedAsset(UObject SourceAsset,string DestinationAssetPath) { return default; }
	public static UObject DuplicateAsset(string SourceAssetPath,string DestinationAssetPath) { return default; }
	public static bool DuplicateDirectory(string SourceDirectoryPath,string DestinationDirectoryPath) { return default; }
	public static bool RenameLoadedAsset(UObject SourceAsset,string DestinationAssetPath) { return default; }
	public static bool RenameAsset(string SourceAssetPath,string DestinationAssetPath) { return default; }
	public static bool RenameDirectory(string SourceDirectoryPath,string DestinationDirectoryPath) { return default; }
	public static bool CheckoutLoadedAsset(UObject AssetToCheckout) { return default; }
	public static bool CheckoutLoadedAssets(TArray<UObject> AssetsToCheckout) { return default; }
	public static bool CheckoutAsset(string AssetToCheckout) { return default; }
	public static bool CheckoutDirectory(string DirectoryPath,bool bRecursive/*=true*/) { return default; }
	public static bool SaveLoadedAsset(UObject AssetToSave,bool bOnlyIfIsDirty/*=true*/) { return default; }
	public static bool SaveLoadedAssets(TArray<UObject> AssetsToSave,bool bOnlyIfIsDirty/*=true*/) { return default; }
	public static bool SaveAsset(string AssetToSave,bool bOnlyIfIsDirty/*=true*/) { return default; }
	public static bool SaveDirectory(string DirectoryPath,bool bOnlyIfIsDirty/*=true*/,bool bRecursive/*=true*/) { return default; }
	public static bool DoesDirectoryExist(string DirectoryPath) { return default; }
	public static bool DoesDirectoryHaveAssets(string DirectoryPath,bool bRecursive/*=true*/) { return default; }
	public static bool MakeDirectory(string DirectoryPath) { return default; }
	public static TArray<string> ListAssets(string DirectoryPath,bool bRecursive/*=true*/,bool bIncludeFolder/*=false*/) { return default; }
	public static TArray<string> ListAssetByTagValue(string TagName,string TagValue) { return default; }
	public static TMap<string,string> GetTagValues(string AssetPath) { return default; }
	public static TMap<string,string> GetMetadataTagValues(UObject Object) { return default; }
	public static string GetMetadataTag(UObject Object,string Tag) { return default; }
	public static void SetMetadataTag(UObject Object,string Tag,string Value) {}
	public static void RemoveMetadataTag(UObject Object,string Tag) {}
	public static void SyncBrowserToObjects(TArray<string> AssetPaths) {}
}
