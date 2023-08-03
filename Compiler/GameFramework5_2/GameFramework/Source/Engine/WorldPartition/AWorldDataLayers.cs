#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor containing data layers instances within a world.</summary>
[CppInclude("WorldPartition/DataLayer/WorldDataLayers.h")]
public partial class AWorldDataLayers : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>OnDataLayerRuntimeStateChanged</summary>
	public  void OnDataLayerRuntimeStateChanged(UDataLayerInstance InDataLayer,EDataLayerRuntimeState InState) {}
	///<summary>OnRep_ActiveDataLayerNames</summary>
	public  void OnRep_ActiveDataLayerNames() {}
	///<summary>OnRep_LoadedDataLayerNames</summary>
	public  void OnRep_LoadedDataLayerNames() {}
	///<summary>OnRep_EffectiveActiveDataLayerNames</summary>
	public  void OnRep_EffectiveActiveDataLayerNames() {}
	///<summary>OnRep_EffectiveLoadedDataLayerNames</summary>
	public  void OnRep_EffectiveLoadedDataLayerNames() {}
	///<summary>True when Runtime Data Layer editing is allowed.</summary>
	public bool bAllowRuntimeDataLayerEditing;
	///<summary>CurrentDataLayers</summary>
	public FActorPlacementDataLayers CurrentDataLayers;
	///<summary>DataLayerInstances</summary>
	public TSet<UDataLayerInstance> DataLayerInstances;
	///<summary>DeprecatedDataLayerNameToDataLayerInstance</summary>
	public TMap<string,TWeakObjectPtr<UDataLayerInstance>> DeprecatedDataLayerNameToDataLayerInstance;
	///<summary>WorldDataLayers_DEPRECATED</summary>
	public TSet<UDEPRECATED_DataLayer> WorldDataLayers_DEPRECATED;
	///<summary>RepActiveDataLayerNames</summary>
	public TArray<string> RepActiveDataLayerNames;
	///<summary>RepLoadedDataLayerNames</summary>
	public TArray<string> RepLoadedDataLayerNames;
	///<summary>RepEffectiveActiveDataLayerNames</summary>
	public TArray<string> RepEffectiveActiveDataLayerNames;
	///<summary>RepEffectiveLoadedDataLayerNames</summary>
	public TArray<string> RepEffectiveLoadedDataLayerNames;
}
