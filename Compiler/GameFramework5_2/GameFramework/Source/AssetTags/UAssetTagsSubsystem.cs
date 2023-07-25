#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetTagsSubsystem.h")]
public partial class UAssetTagsSubsystem : UEngineSubsystem {
// AssetTagsSubsystem
	public bool CreateCollection(string Name,ECollectionScriptingShareType ShareType) { return default; }
	public bool DestroyCollection(string Name) { return default; }
	public bool RenameCollection(string Name,string NewName) { return default; }
	public bool ReparentCollection(string Name,string NewParentName) { return default; }
	public bool EmptyCollection(string Name) { return default; }
	public bool K2_AddAssetToCollection(string Name,FSoftObjectPath AssetPath) { return default; }
	public bool AddAssetToCollection(string Name,string AssetPathName) { return default; }
	public bool AddAssetDataToCollection(string Name,FAssetData AssetData) { return default; }
	public bool AddAssetPtrToCollection(string Name,UObject AssetPtr) { return default; }
	public bool K2_AddAssetsToCollection(string Name,TArray<FSoftObjectPath> AssetPaths) { return default; }
	public bool AddAssetsToCollection(string Name,TArray<string> AssetPathNames) { return default; }
	public bool AddAssetDatasToCollection(string Name,TArray<FAssetData> AssetDatas) { return default; }
	public bool AddAssetPtrsToCollection(string Name,TArray<UObject> AssetPtrs) { return default; }
	public bool K2_RemoveAssetFromCollection(string Name,FSoftObjectPath AssetPath) { return default; }
	public bool RemoveAssetFromCollection(string Name,string AssetPathName) { return default; }
	public bool RemoveAssetDataFromCollection(string Name,FAssetData AssetData) { return default; }
	public bool RemoveAssetPtrFromCollection(string Name,UObject AssetPtr) { return default; }
	public bool K2_RemoveAssetsFromCollection(string Name,TArray<FSoftObjectPath> AssetPaths) { return default; }
	public bool RemoveAssetsFromCollection(string Name,TArray<string> AssetPathNames) { return default; }
	public bool RemoveAssetDatasFromCollection(string Name,TArray<FAssetData> AssetDatas) { return default; }
	public bool RemoveAssetPtrsFromCollection(string Name,TArray<UObject> AssetPtrs) { return default; }
	public bool CollectionExists(string Name) { return default; }
	public TArray<string> GetCollections() { return default; }
	public TArray<FAssetData> GetAssetsInCollection(string Name) { return default; }
	public TArray<string> K2_GetCollectionsContainingAsset(FSoftObjectPath AssetPath) { return default; }
	public TArray<string> GetCollectionsContainingAsset(string AssetPathName) { return default; }
	public TArray<string> GetCollectionsContainingAssetData(FAssetData AssetData) { return default; }
	public TArray<string> GetCollectionsContainingAssetPtr(UObject AssetPtr) { return default; }
}
