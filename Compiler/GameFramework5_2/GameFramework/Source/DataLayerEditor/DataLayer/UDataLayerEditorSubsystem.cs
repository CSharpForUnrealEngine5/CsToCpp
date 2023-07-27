#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataLayer/DataLayerEditorSubsystem.h")]
public partial class UDataLayerEditorSubsystem : UEditorSubsystem {
// DataLayerEditorSubsystem
	public  bool IsActorValidForDataLayer(AActor Actor) { return default; }
	public  bool AddActorToDataLayer(AActor Actor,UDataLayerInstance DataLayer) { return default; }
	public  bool AddActorToDataLayers(AActor Actor,TArray<UDataLayerInstance> DataLayers) { return default; }
	public  bool RemoveActorFromDataLayer(AActor Actor,UDataLayerInstance DataLayerToRemove) { return default; }
	public  bool RemoveActorFromDataLayers(AActor Actor,TArray<UDataLayerInstance> DataLayers) { return default; }
	public  bool RemoveActorFromAllDataLayers(AActor Actor) { return default; }
	public  bool RemoveActorsFromAllDataLayers(TArray<AActor> Actors) { return default; }
	public  bool AddActorsToDataLayer(TArray<AActor> Actors,UDataLayerInstance DataLayer) { return default; }
	public  bool AddActorsToDataLayers(TArray<AActor> Actors,TArray<UDataLayerInstance> DataLayers) { return default; }
	public  bool RemoveActorsFromDataLayer(TArray<AActor> Actors,UDataLayerInstance DataLayer) { return default; }
	public  bool RemoveActorsFromDataLayers(TArray<AActor> Actors,TArray<UDataLayerInstance> DataLayers) { return default; }
	public  bool AddSelectedActorsToDataLayer(UDataLayerInstance DataLayer) { return default; }
	public  bool AddSelectedActorsToDataLayers(TArray<UDataLayerInstance> DataLayers) { return default; }
	public  bool RemoveSelectedActorsFromDataLayer(UDataLayerInstance DataLayer) { return default; }
	public  bool RemoveSelectedActorsFromDataLayers(TArray<UDataLayerInstance> DataLayers) { return default; }
	public  bool SelectActorsInDataLayer(UDataLayerInstance DataLayer,bool bSelect,bool bNotify,bool bSelectEvenIfHidden/*=false*/) { return default; }
	public  bool SelectActorsInDataLayers(TArray<UDataLayerInstance> DataLayers,bool bSelect,bool bNotify,bool bSelectEvenIfHidden/*=false*/) { return default; }
	public  bool UpdateActorVisibility(AActor Actor,bool bOutSelectionChanged,bool bOutActorModified,bool bNotifySelectionChange,bool bRedrawViewports) { return default; }
	public  bool UpdateAllActorsVisibility(bool bNotifySelectionChange,bool bRedrawViewports) { return default; }
	public  void AppendActorsFromDataLayer(UDataLayerInstance DataLayer,TArray<AActor> InOutActors) {}
	public  void AppendActorsFromDataLayers(TArray<UDataLayerInstance> DataLayers,TArray<AActor> InOutActors) {}
	public  TArray<AActor> GetActorsFromDataLayer(UDataLayerInstance DataLayer) { return default; }
	public  TArray<AActor> GetActorsFromDataLayers(TArray<UDataLayerInstance> DataLayers) { return default; }
	public  void SetDataLayerVisibility(UDataLayerInstance DataLayer,bool bIsVisible) {}
	public  void SetDataLayersVisibility(TArray<UDataLayerInstance> DataLayers,bool bIsVisible) {}
	public  void ToggleDataLayerVisibility(UDataLayerInstance DataLayer) {}
	public  void ToggleDataLayersVisibility(TArray<UDataLayerInstance> DataLayers) {}
	public  bool SetDataLayerIsLoadedInEditor(UDataLayerInstance DataLayer,bool bIsLoadedInEditor,bool bIsFromUserChange) { return default; }
	public  bool SetDataLayersIsLoadedInEditor(TArray<UDataLayerInstance> DataLayers,bool bIsLoadedInEditor,bool bIsFromUserChange) { return default; }
	public  bool ToggleDataLayerIsLoadedInEditor(UDataLayerInstance DataLayer,bool bIsFromUserChange) { return default; }
	public  bool ToggleDataLayersIsLoadedInEditor(TArray<UDataLayerInstance> DataLayers,bool bIsFromUserChange) { return default; }
	public  void MakeAllDataLayersVisible() {}
	public  UDataLayerInstance GetDataLayerInstance(UDataLayerAsset DataLayerAsset) { return default; }
	public  TArray<UDataLayerInstance> GetDataLayerInstances(TArray<UDataLayerAsset> DataLayerAssets) { return default; }
	public  UDataLayerInstance CreateDataLayerInstance(FDataLayerCreationParameters Parameters) { return default; }
	public  bool SetParentDataLayer(UDataLayerInstance DataLayer,UDataLayerInstance ParentDataLayer) { return default; }
	public  void DeleteDataLayers(TArray<UDataLayerInstance> DataLayersToDelete) {}
	public  void DeleteDataLayer(UDataLayerInstance DataLayerToDelete) {}
	public  TArray<UDataLayerInstance> GetAllDataLayers() { return default; }
	public  void UpdateAllViewVisibility(UDEPRECATED_DataLayer DataLayerThatChanged) {}
	public  void UpdateActorAllViewsVisibility(AActor Actor) {}
	public  bool SetDataLayerIsDynamicallyLoadedInEditor(UDEPRECATED_DataLayer DataLayer,bool bIsLoadedInEditor,bool bIsFromUserChange) { return default; }
	public  bool SetDataLayersIsDynamicallyLoadedInEditor(TArray<UDEPRECATED_DataLayer> DataLayers,bool bIsLoadedInEditor,bool bIsFromUserChange) { return default; }
	public  bool ToggleDataLayerIsDynamicallyLoadedInEditor(UDEPRECATED_DataLayer DataLayer,bool bIsFromUserChange) { return default; }
	public  bool ToggleDataLayersIsDynamicallyLoadedInEditor(TArray<UDEPRECATED_DataLayer> DataLayers,bool bIsFromUserChange) { return default; }
	public  UDataLayerInstance GetDataLayer(FActorDataLayer ActorDataLayer) { return default; }
	public  UDataLayerInstance GetDataLayerFromLabel(string DataLayerLabel) { return default; }
	public  bool RenameDataLayer(UDataLayerInstance DataLayer,string NewDataLayerLabel) { return default; }
	public  UDataLayerInstance CreateDataLayer(UDataLayerInstance ParentDataLayer/*=nullptr*/) { return default; }
}
