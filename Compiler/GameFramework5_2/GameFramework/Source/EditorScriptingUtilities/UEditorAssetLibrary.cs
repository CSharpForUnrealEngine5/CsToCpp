#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorAssetLibrary.h")]
///<summary>Utility class to do most of the common functionalities with the ContentBrowser.</summary>
public partial class UEditorAssetLibrary : UBlueprintFunctionLibrary {
// EditorAssetLibrary
	public UObject LoadAsset(string AssetPath) { return default; }
	public UClass LoadBlueprintClass(string AssetPath) { return default; }
	public string GetPathNameForLoadedAsset(UObject LoadedAsset) { return default; }
	public FAssetData FindAssetData(string AssetPath) { return default; }
	public bool DoesAssetExist(string AssetPath) { return default; }
	public bool DoAssetsExist(TArray<string> AssetPaths) { return default; }
	public TArray<string> FindPackageReferencersForAsset(string AssetPath,bool bLoadAssetsToConfirm/*=false*/) { return default; }
	public bool ConsolidateAssets(UObject AssetToConsolidateTo,TArray<UObject> AssetsToConsolidate) { return default; }
	public bool DeleteLoadedAsset(UObject AssetToDelete) { return default; }
	public bool DeleteLoadedAssets(TArray<UObject> AssetsToDelete) { return default; }
	public bool DeleteAsset(string AssetPathToDelete) { return default; }
	public bool DeleteDirectory(string DirectoryPath) { return default; }
	public UObject DuplicateLoadedAsset(UObject SourceAsset,string DestinationAssetPath) { return default; }
	public UObject DuplicateAsset(string SourceAssetPath,string DestinationAssetPath) { return default; }
	public bool DuplicateDirectory(string SourceDirectoryPath,string DestinationDirectoryPath) { return default; }
	public bool RenameLoadedAsset(UObject SourceAsset,string DestinationAssetPath) { return default; }
	public bool RenameAsset(string SourceAssetPath,string DestinationAssetPath) { return default; }
	public bool RenameDirectory(string SourceDirectoryPath,string DestinationDirectoryPath) { return default; }
	public bool CheckoutLoadedAsset(UObject AssetToCheckout) { return default; }
	public bool CheckoutLoadedAssets(TArray<UObject> AssetsToCheckout) { return default; }
	public bool CheckoutAsset(string AssetToCheckout) { return default; }
	public bool CheckoutDirectory(string DirectoryPath,bool bRecursive/*=true*/) { return default; }
	public bool SaveLoadedAsset(UObject AssetToSave,bool bOnlyIfIsDirty/*=true*/) { return default; }
	public bool SaveLoadedAssets(TArray<UObject> AssetsToSave,bool bOnlyIfIsDirty/*=true*/) { return default; }
	public bool SaveAsset(string AssetToSave,bool bOnlyIfIsDirty/*=true*/) { return default; }
	public bool SaveDirectory(string DirectoryPath,bool bOnlyIfIsDirty/*=true*/,bool bRecursive/*=true*/) { return default; }
	public bool DoesDirectoryExist(string DirectoryPath) { return default; }
	public bool DoesDirectoryHaveAssets(string DirectoryPath,bool bRecursive/*=true*/) { return default; }
	public bool MakeDirectory(string DirectoryPath) { return default; }
	public TArray<string> ListAssets(string DirectoryPath,bool bRecursive/*=true*/,bool bIncludeFolder/*=false*/) { return default; }
	public TArray<string> ListAssetByTagValue(string TagName,string TagValue) { return default; }
	public TMap<string,string> GetTagValues(string AssetPath) { return default; }
	public TMap<string,string> GetMetadataTagValues(UObject Object) { return default; }
	public string GetMetadataTag(UObject Object,string Tag) { return default; }
	public void SetMetadataTag(UObject Object,string Tag,string Value) {}
	public void RemoveMetadataTag(UObject Object,string Tag) {}
	public void SyncBrowserToObjects(TArray<string> AssetPaths) {}
}
