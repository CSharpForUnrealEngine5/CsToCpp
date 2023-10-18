namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Owns the assets generated and reused by the USD stage, allowing thread-safe retrieval/storage</summary>
[CppInclude("USDAssetCache.h")]
public partial class UUsdAssetCache : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>For now everything is NonPIEDuplicateTransient as this is mostly a subobject of AUsdStageActor. When the actor is duplicated</summary>
	public TMap<string,UObject> TransientStorage;
	///<summary>PersistentStorage</summary>
	public TMap<string,UObject> PersistentStorage;
	///<summary>bAllowPersistentStorage</summary>
	public bool bAllowPersistentStorage;
	///<summary>Points to the assets in primary storage, used to quickly check if we own an asset</summary>
	public TSet<TWeakObjectPtr<UObject>> OwnedAssets;
	///<summary>Keeps associations from prim paths to assets that we own in primary storage</summary>
	public TMap<string,TWeakObjectPtr<UObject>> PrimPathToAssets;
}
