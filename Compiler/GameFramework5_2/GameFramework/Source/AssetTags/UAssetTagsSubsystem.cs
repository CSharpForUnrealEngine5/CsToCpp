#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetTagsSubsystem.h")]
public partial class UAssetTagsSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Create a new collection with the given name and share type.</summary>
	public  bool CreateCollection(string Name,ECollectionScriptingShareType ShareType) { return default; }
	///<summary>Destroy the given collection.</summary>
	public  bool DestroyCollection(string Name) { return default; }
	///<summary>Rename the given collection.</summary>
	public  bool RenameCollection(string Name,string NewName) { return default; }
	///<summary>Re-parent the given collection.</summary>
	public  bool ReparentCollection(string Name,string NewParentName) { return default; }
	///<summary>Remove all assets from the given collection.</summary>
	public  bool EmptyCollection(string Name) { return default; }
	///<summary>Add the given asset to the given collection.</summary>
	public  bool K2_AddAssetToCollection(string Name,FSoftObjectPath AssetPath) { return default; }
	///<summary>AddAssetToCollection</summary>
	public  bool AddAssetToCollection(string Name,string AssetPathName) { return default; }
	///<summary>Add the given asset to the given collection.</summary>
	public  bool AddAssetDataToCollection(string Name,FAssetData AssetData) { return default; }
	///<summary>Add the given asset to the given collection.</summary>
	public  bool AddAssetPtrToCollection(string Name,UObject AssetPtr) { return default; }
	///<summary>Add the given assets to the given collection.</summary>
	public  bool K2_AddAssetsToCollection(string Name,TArray<FSoftObjectPath> AssetPaths) { return default; }
	///<summary>AddAssetsToCollection</summary>
	public  bool AddAssetsToCollection(string Name,TArray<string> AssetPathNames) { return default; }
	///<summary>Add the given assets to the given collection.</summary>
	public  bool AddAssetDatasToCollection(string Name,TArray<FAssetData> AssetDatas) { return default; }
	///<summary>Add the given assets to the given collection.</summary>
	public  bool AddAssetPtrsToCollection(string Name,TArray<UObject> AssetPtrs) { return default; }
	///<summary>Remove the given asset from the given collection.</summary>
	public  bool K2_RemoveAssetFromCollection(string Name,FSoftObjectPath AssetPath) { return default; }
	///<summary>RemoveAssetFromCollection</summary>
	public  bool RemoveAssetFromCollection(string Name,string AssetPathName) { return default; }
	///<summary>Remove the given asset from the given collection.</summary>
	public  bool RemoveAssetDataFromCollection(string Name,FAssetData AssetData) { return default; }
	///<summary>Remove the given asset from the given collection.</summary>
	public  bool RemoveAssetPtrFromCollection(string Name,UObject AssetPtr) { return default; }
	///<summary>Remove the given assets from the given collection.</summary>
	public  bool K2_RemoveAssetsFromCollection(string Name,TArray<FSoftObjectPath> AssetPaths) { return default; }
	///<summary>RemoveAssetsFromCollection</summary>
	public  bool RemoveAssetsFromCollection(string Name,TArray<string> AssetPathNames) { return default; }
	///<summary>Remove the given assets from the given collection.</summary>
	public  bool RemoveAssetDatasFromCollection(string Name,TArray<FAssetData> AssetDatas) { return default; }
	///<summary>Remove the given assets from the given collection.</summary>
	public  bool RemoveAssetPtrsFromCollection(string Name,TArray<UObject> AssetPtrs) { return default; }
	///<summary>Check whether the given collection exists.</summary>
	public  bool CollectionExists(string Name) { return default; }
	///<summary>Get the names of all available collections.</summary>
	public  TArray<string> GetCollections() { return default; }
	///<summary>Get the assets in the given collection.</summary>
	public  TArray<FAssetData> GetAssetsInCollection(string Name) { return default; }
	///<summary>Get the names of the collections that contain the given asset.</summary>
	public  TArray<string> K2_GetCollectionsContainingAsset(FSoftObjectPath AssetPath) { return default; }
	///<summary>GetCollectionsContainingAsset</summary>
	public  TArray<string> GetCollectionsContainingAsset(string AssetPathName) { return default; }
	///<summary>Get the names of the collections that contain the given asset.</summary>
	public  TArray<string> GetCollectionsContainingAssetData(FAssetData AssetData) { return default; }
	///<summary>Get the names of the collections that contain the given asset.</summary>
	public  TArray<string> GetCollectionsContainingAssetPtr(UObject AssetPtr) { return default; }
}
