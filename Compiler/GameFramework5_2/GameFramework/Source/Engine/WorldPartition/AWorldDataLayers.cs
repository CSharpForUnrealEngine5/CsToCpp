#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/WorldDataLayers.h")]
///<summary>Actor containing data layers instances within a world.</summary>
public partial class AWorldDataLayers : AInfo {
// WorldDataLayers
	public  void OnDataLayerRuntimeStateChanged(UDataLayerInstance InDataLayer,EDataLayerRuntimeState InState) {}
	public  void OnRep_ActiveDataLayerNames() {}
	public  void OnRep_LoadedDataLayerNames() {}
	public  void OnRep_EffectiveActiveDataLayerNames() {}
	public  void OnRep_EffectiveLoadedDataLayerNames() {}
	public bool bAllowRuntimeDataLayerEditing;
	public FActorPlacementDataLayers CurrentDataLayers;
	public TSet<UDataLayerInstance> DataLayerInstances;
	public TMap<string,TWeakObjectPtr<UDataLayerInstance>> DeprecatedDataLayerNameToDataLayerInstance;
	public TSet<UDEPRECATED_DataLayer> WorldDataLayers_DEPRECATED;
	public TArray<string> RepActiveDataLayerNames;
	public TArray<string> RepLoadedDataLayerNames;
	public TArray<string> RepEffectiveActiveDataLayerNames;
	public TArray<string> RepEffectiveLoadedDataLayerNames;
}
