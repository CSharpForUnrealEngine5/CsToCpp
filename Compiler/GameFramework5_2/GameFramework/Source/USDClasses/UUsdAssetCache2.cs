#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDAssetCache2.h")]
///<summary>Owns the assets generated and reused by USD Stages, allowing thread-safe retrieval/storage.</summary>
public partial class UUsdAssetCache2 : UObject {
// UsdAssetCache2
	public double UnreferencedAssetStorageSizeMB;
	public double PersistentAssetStorageSizeMB;
	public void CacheAsset(string Hash,UObject Asset,UObject Referencer/*=nullptr*/) {}
	public bool CanRemoveAsset(string Hash) { return default; }
	public UObject RemoveAsset(string Hash) { return default; }
	public UObject GetCachedAsset(string Hash) { return default; }
	public bool AddAssetReference(UObject Asset,UObject Referencer) { return default; }
	public bool RemoveAssetReference(UObject Asset,UObject Referencer) { return default; }
	public bool RemoveAllAssetReferences(UObject Referencer) { return default; }
	public string GetHashForAsset(UObject Asset) { return default; }
	public bool IsAssetOwnedByCache(string AssetPath) { return default; }
	public int GetNumAssets() { return default; }
	public TArray<string> GetAllAssetHashes() { return default; }
	public TArray<UObject> GetAllLoadedAssets() { return default; }
	public TArray<string> GetAllCachedAssetPaths() { return default; }
	public void Reset() {}
	public void RefreshStorage() {}
	public TMap<string,UObject> AssetStorage;
}
