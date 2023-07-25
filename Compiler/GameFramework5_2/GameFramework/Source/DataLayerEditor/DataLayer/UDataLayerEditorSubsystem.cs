#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataLayer/DataLayerEditorSubsystem.h")]
public partial class UDataLayerEditorSubsystem : UEditorSubsystem {
// DataLayerEditorSubsystem
	public bool IsActorValidForDataLayer(UObject Actor) { return default; }
	public bool AddActorToDataLayer(UObject Actor,UObject DataLayer) { return default; }
	public bool AddActorToDataLayers(UObject Actor,TArray<UObject> DataLayers) { return default; }
	public bool RemoveActorFromDataLayer(UObject Actor,UObject DataLayerToRemove) { return default; }
	public bool RemoveActorFromDataLayers(UObject Actor,TArray<UObject> DataLayers) { return default; }
	public bool RemoveActorFromAllDataLayers(UObject Actor) { return default; }
	public bool RemoveActorsFromAllDataLayers(TArray<UObject> Actors) { return default; }
	public bool AddActorsToDataLayer(TArray<UObject> Actors,UObject DataLayer) { return default; }
	public bool AddActorsToDataLayers(TArray<UObject> Actors,TArray<UObject> DataLayers) { return default; }
	public bool RemoveActorsFromDataLayer(TArray<UObject> Actors,UObject DataLayer) { return default; }
	public bool RemoveActorsFromDataLayers(TArray<UObject> Actors,TArray<UObject> DataLayers) { return default; }
	public bool AddSelectedActorsToDataLayer(UObject DataLayer) { return default; }
	public bool AddSelectedActorsToDataLayers(TArray<UObject> DataLayers) { return default; }
	public bool RemoveSelectedActorsFromDataLayer(UObject DataLayer) { return default; }
	public bool RemoveSelectedActorsFromDataLayers(TArray<UObject> DataLayers) { return default; }
	public bool SelectActorsInDataLayer(UObject DataLayer,bool bSelect,bool bNotify,bool bSelectEvenIfHidden/*=false*/) { return default; }
	public bool SelectActorsInDataLayers(TArray<UObject> DataLayers,bool bSelect,bool bNotify,bool bSelectEvenIfHidden/*=false*/) { return default; }
	public bool UpdateActorVisibility(UObject Actor,bool bOutSelectionChanged,bool bOutActorModified,bool bNotifySelectionChange,bool bRedrawViewports) { return default; }
	public bool UpdateAllActorsVisibility(bool bNotifySelectionChange,bool bRedrawViewports) { return default; }
	public void AppendActorsFromDataLayer(UObject DataLayer,TArray<UObject> InOutActors) {}
	public void AppendActorsFromDataLayers(TArray<UObject> DataLayers,TArray<UObject> InOutActors) {}
	public TArray<UObject> GetActorsFromDataLayer(UObject DataLayer) { return default; }
	public TArray<UObject> GetActorsFromDataLayers(TArray<UObject> DataLayers) { return default; }
	public void SetDataLayerVisibility(UObject DataLayer,bool bIsVisible) {}
	public void SetDataLayersVisibility(TArray<UObject> DataLayers,bool bIsVisible) {}
	public void ToggleDataLayerVisibility(UObject DataLayer) {}
	public void ToggleDataLayersVisibility(TArray<UObject> DataLayers) {}
	public bool SetDataLayerIsLoadedInEditor(UObject DataLayer,bool bIsLoadedInEditor,bool bIsFromUserChange) { return default; }
	public bool SetDataLayersIsLoadedInEditor(TArray<UObject> DataLayers,bool bIsLoadedInEditor,bool bIsFromUserChange) { return default; }
	public bool ToggleDataLayerIsLoadedInEditor(UObject DataLayer,bool bIsFromUserChange) { return default; }
	public bool ToggleDataLayersIsLoadedInEditor(TArray<UObject> DataLayers,bool bIsFromUserChange) { return default; }
	public void MakeAllDataLayersVisible() {}
	public UObject GetDataLayerInstance(UObject DataLayerAsset) { return default; }
	public TArray<UObject> GetDataLayerInstances(TArray<UObject> DataLayerAssets) { return default; }
	public UObject CreateDataLayerInstance(FDataLayerCreationParameters Parameters) { return default; }
	public bool SetParentDataLayer(UObject DataLayer,UObject ParentDataLayer) { return default; }
	public void DeleteDataLayers(TArray<UObject> DataLayersToDelete) {}
	public void DeleteDataLayer(UObject DataLayerToDelete) {}
	public TArray<UObject> GetAllDataLayers() { return default; }
	public void UpdateAllViewVisibility(UObject DataLayerThatChanged) {}
	public void UpdateActorAllViewsVisibility(UObject Actor) {}
	public bool SetDataLayerIsDynamicallyLoadedInEditor(UObject DataLayer,bool bIsLoadedInEditor,bool bIsFromUserChange) { return default; }
	public bool SetDataLayersIsDynamicallyLoadedInEditor(TArray<UObject> DataLayers,bool bIsLoadedInEditor,bool bIsFromUserChange) { return default; }
	public bool ToggleDataLayerIsDynamicallyLoadedInEditor(UObject DataLayer,bool bIsFromUserChange) { return default; }
	public bool ToggleDataLayersIsDynamicallyLoadedInEditor(TArray<UObject> DataLayers,bool bIsFromUserChange) { return default; }
	public UObject GetDataLayer(FActorDataLayer ActorDataLayer) { return default; }
	public UObject GetDataLayerFromLabel(string DataLayerLabel) { return default; }
	public bool RenameDataLayer(UObject DataLayer,string NewDataLayerLabel) { return default; }
	public UObject CreateDataLayer(UObject ParentDataLayer/*=nullptr*/) { return default; }
}
