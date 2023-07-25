#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayerSubsystem.h")]
public partial class UDataLayerSubsystem : UWorldSubsystem {
// DataLayerSubsystem
	public UObject GetDataLayerInstanceFromAsset(UObject InDataLayerAsset) { return default; }
	public EDataLayerRuntimeState GetDataLayerInstanceRuntimeState(UObject InDataLayerAsset) { return default; }
	public EDataLayerRuntimeState GetDataLayerInstanceEffectiveRuntimeState(UObject InDataLayerAsset) { return default; }
	public void SetDataLayerInstanceRuntimeState(UObject InDataLayerAsset,EDataLayerRuntimeState InState,bool bInIsRecursive/*=false*/) {}
	public FOnDataLayerRuntimeStateChanged OnDataLayerRuntimeStateChanged;
	public void SetDataLayerState(FActorDataLayer InDataLayer,EDataLayerState InState) {}
	public void SetDataLayerStateByLabel(string InDataLayerLabel,EDataLayerState InState) {}
	public EDataLayerState GetDataLayerState(FActorDataLayer InDataLayer) { return default; }
	public EDataLayerState GetDataLayerStateByLabel(string InDataLayerLabel) { return default; }
	public TSet<string> GetActiveDataLayerNames() { return default; }
	public TSet<string> GetLoadedDataLayerNames() { return default; }
	public UObject GetDataLayer(FActorDataLayer InDataLayer) { return default; }
	public UObject GetDataLayerFromName(string InDataLayerName) { return default; }
	public UObject GetDataLayerFromLabel(string InDataLayerLabel) { return default; }
	public EDataLayerRuntimeState GetDataLayerRuntimeState(FActorDataLayer InDataLayer) { return default; }
	public EDataLayerRuntimeState GetDataLayerRuntimeStateByLabel(string InDataLayerLabel) { return default; }
	public EDataLayerRuntimeState GetDataLayerEffectiveRuntimeState(FActorDataLayer InDataLayer) { return default; }
	public EDataLayerRuntimeState GetDataLayerEffectiveRuntimeStateByLabel(string InDataLayerLabel) { return default; }
	public void SetDataLayerRuntimeState(FActorDataLayer InDataLayer,EDataLayerRuntimeState InState,bool bInIsRecursive/*=false*/) {}
	public void SetDataLayerRuntimeStateByLabel(string InDataLayerLabel,EDataLayerRuntimeState InState,bool bInIsRecursive/*=false*/) {}
	public TSoftObjectPtr<UClass> DataLayerLoadingPolicyClass;
	public UDataLayerLoadingPolicy DataLayerLoadingPolicy;
}
