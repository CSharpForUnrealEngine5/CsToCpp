namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayerManager.h")]
public partial class UDataLayerManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetDataLayerInstanceFromAsset</summary>
	public UDataLayerInstance GetDataLayerInstanceFromAsset(UDataLayerAsset InDataLayerAsset) { return default; }
	///<summary>GetDataLayerInstanceFromName</summary>
	public UDataLayerInstance GetDataLayerInstanceFromName(FName InDataLayerInstanceName) { return default; }
	///<summary>SetDataLayerInstanceRuntimeState</summary>
	public bool SetDataLayerInstanceRuntimeState(UDataLayerInstance InDataLayerInstance,EDataLayerRuntimeState InState,bool bInIsRecursive/*=false*/) { return default; }
	///<summary>SetDataLayerRuntimeState</summary>
	public bool SetDataLayerRuntimeState(UDataLayerAsset InDataLayerAsset,EDataLayerRuntimeState InState,bool bInIsRecursive/*=false*/) { return default; }
	///<summary>GetDataLayerInstanceRuntimeState</summary>
	public EDataLayerRuntimeState GetDataLayerInstanceRuntimeState(UDataLayerInstance InDataLayerInstance) { return default; }
	///<summary>GetDataLayerInstanceEffectiveRuntimeState</summary>
	public EDataLayerRuntimeState GetDataLayerInstanceEffectiveRuntimeState(UDataLayerInstance InDataLayerInstance) { return default; }
	///<summary>OnDataLayerInstanceRuntimeStateChanged</summary>
	public FOnDataLayerInstanceRuntimeStateChanged OnDataLayerInstanceRuntimeStateChanged;
	///<summary>Referenced objects (used by verse)</summary>
	public TSet<UObject> ReferencedObjects;
	///<summary>DataLayerLoadingPolicyClass</summary>
	public TSoftObjectPtr<UClass> DataLayerLoadingPolicyClass;
	///<summary>DataLayerInstanceWithAssetClass</summary>
	public TSoftObjectPtr<UClass> DataLayerInstanceWithAssetClass;
	///<summary>DataLayerLoadingPolicy</summary>
	public UDataLayerLoadingPolicy DataLayerLoadingPolicy;
}
