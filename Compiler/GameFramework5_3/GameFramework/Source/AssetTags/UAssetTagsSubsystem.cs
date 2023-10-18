namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetTagsSubsystem.h")]
public partial class UAssetTagsSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Create a new collection with the given name and share type.</summary>
	public bool CreateCollection(FName Name,ECollectionScriptingShareType ShareType) { return default; }
	///<summary>Destroy the given collection.</summary>
	public bool DestroyCollection(FName Name) { return default; }
	///<summary>Rename the given collection.</summary>
	public bool RenameCollection(FName Name,FName NewName) { return default; }
	///<summary>Re-parent the given collection.</summary>
	public bool ReparentCollection(FName Name,FName NewParentName) { return default; }
	///<summary>Remove all assets from the given collection.</summary>
	public bool EmptyCollection(FName Name) { return default; }
	///<summary>Add the given asset to the given collection.</summary>
	public bool K2_AddAssetToCollection(FName Name,FSoftObjectPath AssetPath) { return default; }
	///<summary>AddAssetToCollection</summary>
	public bool AddAssetToCollection(FName Name,FName AssetPathName) { return default; }
	///<summary>Add the given asset to the given collection.</summary>
	public bool AddAssetDataToCollection(FName Name,FAssetData AssetData) { return default; }
	///<summary>Add the given asset to the given collection.</summary>
	public bool AddAssetPtrToCollection(FName Name,UObject AssetPtr) { return default; }
	///<summary>Add the given assets to the given collection.</summary>
	public bool K2_AddAssetsToCollection(FName Name,TArray<FSoftObjectPath> AssetPaths) { return default; }
	///<summary>AddAssetsToCollection</summary>
	public bool AddAssetsToCollection(FName Name,TArray<FName> AssetPathNames) { return default; }
	///<summary>Add the given assets to the given collection.</summary>
	public bool AddAssetDatasToCollection(FName Name,TArray<FAssetData> AssetDatas) { return default; }
	///<summary>Add the given assets to the given collection.</summary>
	public bool AddAssetPtrsToCollection(FName Name,TArray<UObject> AssetPtrs) { return default; }
	///<summary>Remove the given asset from the given collection.</summary>
	public bool K2_RemoveAssetFromCollection(FName Name,FSoftObjectPath AssetPath) { return default; }
	///<summary>RemoveAssetFromCollection</summary>
	public bool RemoveAssetFromCollection(FName Name,FName AssetPathName) { return default; }
	///<summary>Remove the given asset from the given collection.</summary>
	public bool RemoveAssetDataFromCollection(FName Name,FAssetData AssetData) { return default; }
	///<summary>Remove the given asset from the given collection.</summary>
	public bool RemoveAssetPtrFromCollection(FName Name,UObject AssetPtr) { return default; }
	///<summary>Remove the given assets from the given collection.</summary>
	public bool K2_RemoveAssetsFromCollection(FName Name,TArray<FSoftObjectPath> AssetPaths) { return default; }
	///<summary>RemoveAssetsFromCollection</summary>
	public bool RemoveAssetsFromCollection(FName Name,TArray<FName> AssetPathNames) { return default; }
	///<summary>Remove the given assets from the given collection.</summary>
	public bool RemoveAssetDatasFromCollection(FName Name,TArray<FAssetData> AssetDatas) { return default; }
	///<summary>Remove the given assets from the given collection.</summary>
	public bool RemoveAssetPtrsFromCollection(FName Name,TArray<UObject> AssetPtrs) { return default; }
	///<summary>Check whether the given collection exists.</summary>
	public bool CollectionExists(FName Name) { return default; }
	///<summary>Get the names of all available collections.</summary>
	public TArray<FName> GetCollections() { return default; }
	///<summary>Get the assets in the given collection.</summary>
	public TArray<FAssetData> GetAssetsInCollection(FName Name) { return default; }
	///<summary>Get the names of the collections that contain the given asset.</summary>
	public TArray<FName> K2_GetCollectionsContainingAsset(FSoftObjectPath AssetPath) { return default; }
	///<summary>GetCollectionsContainingAsset</summary>
	public TArray<FName> GetCollectionsContainingAsset(FName AssetPathName) { return default; }
	///<summary>Get the names of the collections that contain the given asset.</summary>
	public TArray<FName> GetCollectionsContainingAssetData(FAssetData AssetData) { return default; }
	///<summary>Get the names of the collections that contain the given asset.</summary>
	public TArray<FName> GetCollectionsContainingAssetPtr(UObject AssetPtr) { return default; }
}
