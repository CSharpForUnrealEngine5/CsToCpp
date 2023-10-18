namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is deprecated, it has been replaced by DataLayerManager.</summary>
[CppInclude("WorldPartition/DataLayer/DataLayerSubsystem.h")]
public partial class UDataLayerSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>GetDataLayerInstanceFromAsset</summary>
	public UDataLayerInstance GetDataLayerInstanceFromAsset(UDataLayerAsset InDataLayerAsset) { return default; }
	///<summary>GetDataLayerInstanceRuntimeState</summary>
	public EDataLayerRuntimeState GetDataLayerInstanceRuntimeState(UDataLayerAsset InDataLayerAsset) { return default; }
	///<summary>GetDataLayerInstanceEffectiveRuntimeState</summary>
	public EDataLayerRuntimeState GetDataLayerInstanceEffectiveRuntimeState(UDataLayerAsset InDataLayerAsset) { return default; }
	///<summary>SetDataLayerInstanceRuntimeState</summary>
	public void SetDataLayerInstanceRuntimeState(UDataLayerAsset InDataLayerAsset,EDataLayerRuntimeState InState,bool bInIsRecursive/*=false*/) {}
	///<summary>OnDataLayerRuntimeStateChanged</summary>
	public FOnDataLayerRuntimeStateChanged OnDataLayerRuntimeStateChanged;
	///<summary>SetDataLayerState</summary>
	public void SetDataLayerState(FActorDataLayer InDataLayer,EDataLayerState InState) {}
	///<summary>SetDataLayerStateByLabel</summary>
	public void SetDataLayerStateByLabel(FName InDataLayerLabel,EDataLayerState InState) {}
	///<summary>GetDataLayerState</summary>
	public EDataLayerState GetDataLayerState(FActorDataLayer InDataLayer) { return default; }
	///<summary>GetDataLayerStateByLabel</summary>
	public EDataLayerState GetDataLayerStateByLabel(FName InDataLayerLabel) { return default; }
	///<summary>GetActiveDataLayerNames</summary>
	public TSet<FName> GetActiveDataLayerNames() { return default; }
	///<summary>GetLoadedDataLayerNames</summary>
	public TSet<FName> GetLoadedDataLayerNames() { return default; }
	///<summary>GetDataLayer</summary>
	public UDataLayerInstance GetDataLayer(FActorDataLayer InDataLayer) { return default; }
	///<summary>GetDataLayerFromName</summary>
	public UDataLayerInstance GetDataLayerFromName(FName InDataLayerName) { return default; }
	///<summary>GetDataLayerFromLabel</summary>
	public UDataLayerInstance GetDataLayerFromLabel(FName InDataLayerLabel) { return default; }
	///<summary>GetDataLayerRuntimeState</summary>
	public EDataLayerRuntimeState GetDataLayerRuntimeState(FActorDataLayer InDataLayer) { return default; }
	///<summary>GetDataLayerRuntimeStateByLabel</summary>
	public EDataLayerRuntimeState GetDataLayerRuntimeStateByLabel(FName InDataLayerLabel) { return default; }
	///<summary>GetDataLayerEffectiveRuntimeState</summary>
	public EDataLayerRuntimeState GetDataLayerEffectiveRuntimeState(FActorDataLayer InDataLayer) { return default; }
	///<summary>GetDataLayerEffectiveRuntimeStateByLabel</summary>
	public EDataLayerRuntimeState GetDataLayerEffectiveRuntimeStateByLabel(FName InDataLayerLabel) { return default; }
	///<summary>SetDataLayerRuntimeState</summary>
	public void SetDataLayerRuntimeState(FActorDataLayer InDataLayer,EDataLayerRuntimeState InState,bool bInIsRecursive/*=false*/) {}
	///<summary>SetDataLayerRuntimeStateByLabel</summary>
	public void SetDataLayerRuntimeStateByLabel(FName InDataLayerLabel,EDataLayerRuntimeState InState,bool bInIsRecursive/*=false*/) {}
	///<summary>DataLayerLoadingPolicyClass</summary>
	public TSoftObjectPtr<UClass> DataLayerLoadingPolicyClass;
}
