namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RuntimeAssetCacheBuilders.h")]
public partial class URuntimeAssetCacheBuilder_ObjectBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Call this to get the asset named AssetName from the runtime asset cache.</summary>
	public void GetFromCacheAsync(FOnAssetCacheComplete OnComplete) {}
	///<summary>GetFromCacheAsyncComplete</summary>
	public void GetFromCacheAsyncComplete(int Handle,FVoidPtrParam DataPtr) {}
	///<summary>When you get OnAssetCacheMiss you need to load/create the asset that is missing.</summary>
	public void OnAssetCacheMiss() {}
	///<summary>Call SaveNewAssetToCache to save an asset back into the cache for next time.</summary>
	public void SaveNewAssetToCache(UObject NewAsset) {}
	///<summary>The asset version. Changing this will force a new version of the asset to get cached.</summary>
	public int AssetVersion;
	///<summary>The name of the asset. This should be unique per asset, and is used to look it up from the cache. This should be something that can be known without having Asset in memory (so we can look it up in the cache).</summary>
	public string AssetName;
}
