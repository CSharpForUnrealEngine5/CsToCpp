#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RuntimeAssetCacheBuilders.h")]
public partial class URuntimeAssetCacheBuilder_ObjectBase : UObject {
// RuntimeAssetCacheBuilder_ObjectBase
	public void GetFromCacheAsync(FOnAssetCacheComplete OnComplete) {}
	public void GetFromCacheAsyncComplete(int Handle,FVoidPtrParam DataPtr) {}
	public void OnAssetCacheMiss() {}
	public void SaveNewAssetToCache(UObject NewAsset) {}
	public int AssetVersion;
	public string AssetName;
}
