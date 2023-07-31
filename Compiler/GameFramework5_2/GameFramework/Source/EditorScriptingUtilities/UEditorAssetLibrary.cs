#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility class to do most of the common functionalities with the ContentBrowser.</summary>
[CppInclude("EditorAssetLibrary.h")]
public partial class UEditorAssetLibrary : UBlueprintFunctionLibrary {
	///<summary>Load an asset from the Content Browser. It will verify if the object is already loaded and only load it if it&#39;s necessary.</summary>
	public static UObject LoadAsset(string AssetPath) { return default; }
	///<summary>Load a Blueprint asset from the Content Browser and return its generated class. It will verify if the object is already loaded and only load it if it&#39;s necessary.</summary>
	public static UClass LoadBlueprintClass(string AssetPath) { return default; }
	///<summary>Return a valid AssetPath for a loaded asset. The asset need to be a valid asset in the Content Browser.</summary>
	public static string GetPathNameForLoadedAsset(UObject LoadedAsset) { return default; }
	///<summary>Return the AssetData for the Asset that can then be used with the more complex lib AssetRegistryHelpers.</summary>
	public static FAssetData FindAssetData(string AssetPath) { return default; }
	///<summary>Check if the asset exists in the Content Browser.</summary>
	public static bool DoesAssetExist(string AssetPath) { return default; }
	///<summary>Check if the assets exist in the Content Browser.</summary>
	public static bool DoAssetsExist(TArray<string> AssetPaths) { return default; }
	///<summary>Find Package Referencers for an asset. Only Soft and Hard dependencies would be looked for.</summary>
	public static TArray<string> FindPackageReferencersForAsset(string AssetPath,bool bLoadAssetsToConfirm/*=false*/) { return default; }
	///<summary>Consolidates an asset by replacing all references/uses of the provided AssetsToConsolidate with references to AssetToConsolidateTo.</summary>
	public static bool ConsolidateAssets(UObject AssetToConsolidateTo,TArray<UObject> AssetsToConsolidate) { return default; }
	///<summary>Delete an asset from the Content Browser that is already loaded.</summary>
	public static bool DeleteLoadedAsset(UObject AssetToDelete) { return default; }
	///<summary>Delete assets from the Content Browser that are already loaded.</summary>
	public static bool DeleteLoadedAssets(TArray<UObject> AssetsToDelete) { return default; }
	///<summary>Delete the package the assets live in. All objects that live in the package will be deleted.</summary>
	public static bool DeleteAsset(string AssetPathToDelete) { return default; }
	///<summary>Delete the packages inside a directory. If the directory is then empty, delete the directory.</summary>
	public static bool DeleteDirectory(string DirectoryPath) { return default; }
	///<summary>Duplicate an asset from the Content Browser that is already loaded. Will try to checkout the file.</summary>
	public static UObject DuplicateLoadedAsset(UObject SourceAsset,string DestinationAssetPath) { return default; }
	///<summary>Duplicate an asset from the Content Browser. Will try to checkout the file. The Asset will be loaded before being duplicated.</summary>
	public static UObject DuplicateAsset(string SourceAssetPath,string DestinationAssetPath) { return default; }
	///<summary>Duplicate asset from the Content Browser that are in the folder.</summary>
	public static bool DuplicateDirectory(string SourceDirectoryPath,string DestinationDirectoryPath) { return default; }
	///<summary>Rename an asset from the Content Browser that is already loaded.</summary>
	public static bool RenameLoadedAsset(UObject SourceAsset,string DestinationAssetPath) { return default; }
	///<summary>Rename an asset from the Content Browser. Equivalent to a Move operation.</summary>
	public static bool RenameAsset(string SourceAssetPath,string DestinationAssetPath) { return default; }
	///<summary>Rename assets from the Content Browser that are in the folder.</summary>
	public static bool RenameDirectory(string SourceDirectoryPath,string DestinationDirectoryPath) { return default; }
	///<summary>Checkout the asset from the Content Browser.</summary>
	public static bool CheckoutLoadedAsset(UObject AssetToCheckout) { return default; }
	///<summary>Checkout the assets from the Content Browser.</summary>
	public static bool CheckoutLoadedAssets(TArray<UObject> AssetsToCheckout) { return default; }
	///<summary>Checkout the asset from the Content Browser.</summary>
	public static bool CheckoutAsset(string AssetToCheckout) { return default; }
	///<summary>Checkout assets from the Content Browser. It will load the assets if needed.</summary>
	public static bool CheckoutDirectory(string DirectoryPath,bool bRecursive/*=true*/) { return default; }
	///<summary>Save the packages the assets live in. All objects that live in the package will be saved. Will try to checkout the file.</summary>
	public static bool SaveLoadedAsset(UObject AssetToSave,bool bOnlyIfIsDirty/*=true*/) { return default; }
	///<summary>Save the packages the assets live in. All objects that live in the package will be saved. Will try to checkout the files.</summary>
	public static bool SaveLoadedAssets(TArray<UObject> AssetsToSave,bool bOnlyIfIsDirty/*=true*/) { return default; }
	///<summary>Save the packages the assets live in. All objects that live in the package will be saved.</summary>
	public static bool SaveAsset(string AssetToSave,bool bOnlyIfIsDirty/*=true*/) { return default; }
	///<summary>Save the packages the assets live in inside the directory. All objects that are in the directory will be saved.</summary>
	public static bool SaveDirectory(string DirectoryPath,bool bOnlyIfIsDirty/*=true*/,bool bRecursive/*=true*/) { return default; }
	///<summary>Check is the directory exist in the Content Browser.</summary>
	public static bool DoesDirectoryExist(string DirectoryPath) { return default; }
	///<summary>Check if there any asset that exist in the directory.</summary>
	public static bool DoesDirectoryHaveAssets(string DirectoryPath,bool bRecursive/*=true*/) { return default; }
	///<summary>Create the directory on disk and in the Content Browser.</summary>
	public static bool MakeDirectory(string DirectoryPath) { return default; }
	///<summary>Return the list of all the assets found in the DirectoryPath.</summary>
	public static TArray<string> ListAssets(string DirectoryPath,bool bRecursive/*=true*/,bool bIncludeFolder/*=false*/) { return default; }
	///<summary>Return the list of all the assets that have the pair of Tag/Value.</summary>
	public static TArray<string> ListAssetByTagValue(string TagName,string TagValue) { return default; }
	///<summary>Gets all TagValues (from Asset Registry) associated with an (unloaded) asset as strings value.</summary>
	public static TMap<string,string> GetTagValues(string AssetPath) { return default; }
	///<summary>Get all tags/values of a loaded asset&#39;s metadata.</summary>
	public static TMap<string,string> GetMetadataTagValues(UObject Object) { return default; }
	///<summary>Get the value associated with the given tag of a loaded asset&#39;s metadata.</summary>
	public static string GetMetadataTag(UObject Object,string Tag) { return default; }
	///<summary>Set the value associated with a given tag of a loaded asset&#39;s metadata.</summary>
	public static void SetMetadataTag(UObject Object,string Tag,string Value) {}
	///<summary>Remove the given tag from a loaded asset&#39;s metadata.</summary>
	public static void RemoveMetadataTag(UObject Object,string Tag) {}
	///<summary>Sync the Content Browser to the given asset(s)</summary>
	public static void SyncBrowserToObjects(TArray<string> AssetPaths) {}
}
