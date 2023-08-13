namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayerSubsystem.h")]
public partial class UDataLayerSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Find a Data Layer by its asset.</summary>
	public UDataLayerInstance GetDataLayerInstanceFromAsset(UDataLayerAsset InDataLayerAsset) { return default; }
	///<summary>GetDataLayerInstanceRuntimeState</summary>
	public EDataLayerRuntimeState GetDataLayerInstanceRuntimeState(UDataLayerAsset InDataLayerAsset) { return default; }
	///<summary>GetDataLayerInstanceEffectiveRuntimeState</summary>
	public EDataLayerRuntimeState GetDataLayerInstanceEffectiveRuntimeState(UDataLayerAsset InDataLayerAsset) { return default; }
	///<summary>Set the Data Layer state using its name.</summary>
	public void SetDataLayerInstanceRuntimeState(UDataLayerAsset InDataLayerAsset,EDataLayerRuntimeState InState,bool bInIsRecursive/*=false*/) {}
	///<summary>Called when a Data Layer changes state.</summary>
	public FOnDataLayerRuntimeStateChanged OnDataLayerRuntimeStateChanged;
	///<summary>SetDataLayerState</summary>
	public void SetDataLayerState(FActorDataLayer InDataLayer,EDataLayerState InState) {}
	///<summary>SetDataLayerStateByLabel</summary>
	public void SetDataLayerStateByLabel(string InDataLayerLabel,EDataLayerState InState) {}
	///<summary>GetDataLayerState</summary>
	public EDataLayerState GetDataLayerState(FActorDataLayer InDataLayer) { return default; }
	///<summary>GetDataLayerStateByLabel</summary>
	public EDataLayerState GetDataLayerStateByLabel(string InDataLayerLabel) { return default; }
	///<summary>GetActiveDataLayerNames</summary>
	public TSet<string> GetActiveDataLayerNames() { return default; }
	///<summary>GetLoadedDataLayerNames</summary>
	public TSet<string> GetLoadedDataLayerNames() { return default; }
	///<summary>GetDataLayer</summary>
	public UDataLayerInstance GetDataLayer(FActorDataLayer InDataLayer) { return default; }
	///<summary>GetDataLayerFromName</summary>
	public UDataLayerInstance GetDataLayerFromName(string InDataLayerName) { return default; }
	///<summary>GetDataLayerFromLabel</summary>
	public UDataLayerInstance GetDataLayerFromLabel(string InDataLayerLabel) { return default; }
	///<summary>GetDataLayerRuntimeState</summary>
	public EDataLayerRuntimeState GetDataLayerRuntimeState(FActorDataLayer InDataLayer) { return default; }
	///<summary>GetDataLayerRuntimeStateByLabel</summary>
	public EDataLayerRuntimeState GetDataLayerRuntimeStateByLabel(string InDataLayerLabel) { return default; }
	///<summary>GetDataLayerEffectiveRuntimeState</summary>
	public EDataLayerRuntimeState GetDataLayerEffectiveRuntimeState(FActorDataLayer InDataLayer) { return default; }
	///<summary>GetDataLayerEffectiveRuntimeStateByLabel</summary>
	public EDataLayerRuntimeState GetDataLayerEffectiveRuntimeStateByLabel(string InDataLayerLabel) { return default; }
	///<summary>SetDataLayerRuntimeState</summary>
	public void SetDataLayerRuntimeState(FActorDataLayer InDataLayer,EDataLayerRuntimeState InState,bool bInIsRecursive/*=false*/) {}
	///<summary>SetDataLayerRuntimeStateByLabel</summary>
	public void SetDataLayerRuntimeStateByLabel(string InDataLayerLabel,EDataLayerRuntimeState InState,bool bInIsRecursive/*=false*/) {}
	///<summary>DataLayerLoadingPolicyClass</summary>
	public TSoftObjectPtr<UClass> DataLayerLoadingPolicyClass;
	///<summary>DataLayerLoadingPolicy</summary>
	public UDataLayerLoadingPolicy DataLayerLoadingPolicy;
}
