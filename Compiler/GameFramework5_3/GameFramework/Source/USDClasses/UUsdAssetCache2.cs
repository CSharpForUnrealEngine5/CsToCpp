namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Owns the assets generated and reused by USD Stages, allowing thread-safe retrieval/storage.</summary>
[CppInclude("USDAssetCache2.h")]
public partial class UUsdAssetCache2 : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The asset cache will always retain all currently used assets.</summary>
	public double UnreferencedAssetStorageSizeMB;
	///<summary>This limit specifies how much size is allocated to storing all persistent assets (i.e. assets that will be</summary>
	public double PersistentAssetStorageSizeMB;
	///<summary>Adds an asset to the cache attached to a particular hash, and optionally registering a referencer</summary>
	public void CacheAsset(string Hash,UObject Asset,UObject Referencer/*=nullptr*/) {}
	///<summary>Returns true if the asset with the given hash can be removed from the cache. It will return false in case the</summary>
	public bool CanRemoveAsset(string Hash) { return default; }
	///<summary>If an asset is associated with `Hash`, it will be returned and the asset cache will stop tracking this asset</summary>
	public UObject RemoveAsset(string Hash) { return default; }
	///<summary>Returns an asset associated with a particular `Hash`.</summary>
	public UObject GetCachedAsset(string Hash) { return default; }
	///<summary>Marks the provided asset as being used at this point, optionally adding a specific referencer.</summary>
	public bool TouchAsset(UObject Asset,UObject Referencer/*=nullptr*/) { return default; }
	///<summary>Adds a new UObject referencer to a particular asset, returning true if the operation succeeded.</summary>
	public bool AddAssetReference(UObject Asset,UObject Referencer) { return default; }
	///<summary>Removes an UObject referencer from a particular asset, returning true if the operation succeeded.</summary>
	public bool RemoveAssetReference(UObject Asset,UObject Referencer) { return default; }
	///<summary>Removes the particular referencer to all assets tracked by the cache, if it was a referencer to any of them.</summary>
	public bool RemoveAllAssetReferences(UObject Referencer) { return default; }
	///<summary>Returns the hash associated with an asset, in case we own it. Returns the empty string otherwise.</summary>
	public string GetHashForAsset(UObject Asset) { return default; }
	///<summary>Returns true in case the asset at `AssetPath` is tracked by the cache in any way (persistent asset,</summary>
	public bool IsAssetOwnedByCache(string AssetPath) { return default; }
	///<summary>Returns how many assets are tracked by the asset cache in total (summing up persistent, referenced and</summary>
	public int GetNumAssets() { return default; }
	///<summary>Returns all asset hashes tracked by the asset cache, for all storage types. This includes unloaded</summary>
	public TArray<string> GetAllAssetHashes() { return default; }
	///<summary>Returns all assets that are currently loaded in the asset cache.</summary>
	public TArray<UObject> GetAllLoadedAssets() { return default; }
	///<summary>Returns all asset paths tracked by the asset cache, for all storage types. (e.g.</summary>
	public TArray<string> GetAllCachedAssetPaths() { return default; }
	///<summary>Discards all tracked assets across all storage types</summary>
	public void Reset() {}
	///<summary>Updates which assets belong to each storage type. You must call this in case you perform direct operations on</summary>
	public void RefreshStorage() {}
	///<summary>Main hash to asset storage for all assets that we&#39;re currently using and shouldn&#39;t be GC&#39;d</summary>
	public TMap<string,UObject> AssetStorage;
}
