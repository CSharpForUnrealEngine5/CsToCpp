#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDAssetCache.h")]
///<summary>Owns the assets generated and reused by the USD stage, allowing thread-safe retrieval/storage</summary>
public partial class UUsdAssetCache : UObject {
// UsdAssetCache
	public TMap<string,UObject> TransientStorage;
	public TMap<string,UObject> PersistentStorage;
	public bool bAllowPersistentStorage;
	public TSet<TWeakObjectPtr<UObject>> OwnedAssets;
	public TMap<string,TWeakObjectPtr<UObject>> PrimPathToAssets;
}
