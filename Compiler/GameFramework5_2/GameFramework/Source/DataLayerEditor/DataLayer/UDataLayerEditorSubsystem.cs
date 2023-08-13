namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataLayer/DataLayerEditorSubsystem.h")]
public partial class UDataLayerEditorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Checks to see if the specified actor is in an appropriate state to interact with DataLayers</summary>
	public bool IsActorValidForDataLayer(AActor Actor) { return default; }
	///<summary>Adds the actor to the DataLayer.</summary>
	public bool AddActorToDataLayer(AActor Actor,UDataLayerInstance DataLayer) { return default; }
	///<summary>Adds the provided actor to the DataLayers.</summary>
	public bool AddActorToDataLayers(AActor Actor,TArray<UDataLayerInstance> DataLayers) { return default; }
	///<summary>Removes an actor from the specified DataLayer.</summary>
	public bool RemoveActorFromDataLayer(AActor Actor,UDataLayerInstance DataLayerToRemove) { return default; }
	///<summary>Removes the provided actor from the DataLayers.</summary>
	public bool RemoveActorFromDataLayers(AActor Actor,TArray<UDataLayerInstance> DataLayers) { return default; }
	///<summary>Removes an actor from all DataLayers.</summary>
	public bool RemoveActorFromAllDataLayers(AActor Actor) { return default; }
	///<summary>Removes an actor from all DataLayers.</summary>
	public bool RemoveActorsFromAllDataLayers(TArray<AActor> Actors) { return default; }
	///<summary>Add the actors to the DataLayer</summary>
	public bool AddActorsToDataLayer(TArray<AActor> Actors,UDataLayerInstance DataLayer) { return default; }
	///<summary>Add the actors to the DataLayers</summary>
	public bool AddActorsToDataLayers(TArray<AActor> Actors,TArray<UDataLayerInstance> DataLayers) { return default; }
	///<summary>Removes the actors from the specified DataLayer.</summary>
	public bool RemoveActorsFromDataLayer(TArray<AActor> Actors,UDataLayerInstance DataLayer) { return default; }
	///<summary>Remove the actors from the DataLayers</summary>
	public bool RemoveActorsFromDataLayers(TArray<AActor> Actors,TArray<UDataLayerInstance> DataLayers) { return default; }
	///<summary>Adds selected actors to the DataLayer.</summary>
	public bool AddSelectedActorsToDataLayer(UDataLayerInstance DataLayer) { return default; }
	///<summary>Adds selected actors to the DataLayers.</summary>
	public bool AddSelectedActorsToDataLayers(TArray<UDataLayerInstance> DataLayers) { return default; }
	///<summary>Removes the selected actors from the DataLayer.</summary>
	public bool RemoveSelectedActorsFromDataLayer(UDataLayerInstance DataLayer) { return default; }
	///<summary>Removes selected actors from the DataLayers.</summary>
	public bool RemoveSelectedActorsFromDataLayers(TArray<UDataLayerInstance> DataLayers) { return default; }
	///<summary>Selects/de-selects actors belonging to the DataLayer.</summary>
	public bool SelectActorsInDataLayer(UDataLayerInstance DataLayer,bool bSelect,bool bNotify,bool bSelectEvenIfHidden/*=false*/) { return default; }
	///<summary>Selects/de-selects actors belonging to the DataLayers.</summary>
	public bool SelectActorsInDataLayers(TArray<UDataLayerInstance> DataLayers,bool bSelect,bool bNotify,bool bSelectEvenIfHidden/*=false*/) { return default; }
	///<summary>Updates the provided actors visibility in the viewports</summary>
	public bool UpdateActorVisibility(AActor Actor,bool bOutSelectionChanged,bool bOutActorModified,bool bNotifySelectionChange,bool bRedrawViewports) { return default; }
	///<summary>Updates the visibility of all actors in the viewports</summary>
	public bool UpdateAllActorsVisibility(bool bNotifySelectionChange,bool bRedrawViewports) { return default; }
	///<summary>Appends all the actors associated with the specified DataLayer.</summary>
	public void AppendActorsFromDataLayer(UDataLayerInstance DataLayer,TArray<AActor> InOutActors) {}
	///<summary>Appends all the actors associated with ANY of the specified DataLayers.</summary>
	public void AppendActorsFromDataLayers(TArray<UDataLayerInstance> DataLayers,TArray<AActor> InOutActors) {}
	///<summary>Gets all the actors associated with the specified DataLayer. Analog to AppendActorsFromDataLayer but it returns rather than appends the actors.</summary>
	public TArray<AActor> GetActorsFromDataLayer(UDataLayerInstance DataLayer) { return default; }
	///<summary>Gets all the actors associated with ANY of the specified DataLayers. Analog to AppendActorsFromDataLayers but it returns rather than appends the actors.</summary>
	public TArray<AActor> GetActorsFromDataLayers(TArray<UDataLayerInstance> DataLayers) { return default; }
	///<summary>Changes the DataLayer&#39;s visibility to the provided state</summary>
	public void SetDataLayerVisibility(UDataLayerInstance DataLayer,bool bIsVisible) {}
	///<summary>Changes visibility of the DataLayers to the provided state</summary>
	public void SetDataLayersVisibility(TArray<UDataLayerInstance> DataLayers,bool bIsVisible) {}
	///<summary>Toggles the DataLayer&#39;s visibility</summary>
	public void ToggleDataLayerVisibility(UDataLayerInstance DataLayer) {}
	///<summary>Toggles the visibility of all of the DataLayers</summary>
	public void ToggleDataLayersVisibility(TArray<UDataLayerInstance> DataLayers) {}
	///<summary>Changes the DataLayer&#39;s IsLoadedInEditor flag to the provided state</summary>
	public bool SetDataLayerIsLoadedInEditor(UDataLayerInstance DataLayer,bool bIsLoadedInEditor,bool bIsFromUserChange) { return default; }
	///<summary>Changes the IsLoadedInEditor flag of the DataLayers to the provided state</summary>
	public bool SetDataLayersIsLoadedInEditor(TArray<UDataLayerInstance> DataLayers,bool bIsLoadedInEditor,bool bIsFromUserChange) { return default; }
	///<summary>Toggles the DataLayer&#39;s IsLoadedInEditor flag</summary>
	public bool ToggleDataLayerIsLoadedInEditor(UDataLayerInstance DataLayer,bool bIsFromUserChange) { return default; }
	///<summary>Toggles the IsLoadedInEditor flag of all of the DataLayers</summary>
	public bool ToggleDataLayersIsLoadedInEditor(TArray<UDataLayerInstance> DataLayers,bool bIsFromUserChange) { return default; }
	///<summary>Set the visibility of all DataLayers to true</summary>
	public void MakeAllDataLayersVisible() {}
	///<summary>Gets the UDataLayerInstance associated to the DataLayerAsset</summary>
	public UDataLayerInstance GetDataLayerInstance(UDataLayerAsset DataLayerAsset) { return default; }
	///<summary>Gets the UDataLayerInstances associated to the each DataLayerAssets</summary>
	public TArray<UDataLayerInstance> GetDataLayerInstances(TArray<UDataLayerAsset> DataLayerAssets) { return default; }
	///<summary>Creates a UDataLayerInstance Object</summary>
	public UDataLayerInstance CreateDataLayerInstance(FDataLayerCreationParameters Parameters) { return default; }
	///<summary>Sets a Parent DataLayer for a specified DataLayer</summary>
	public bool SetParentDataLayer(UDataLayerInstance DataLayer,UDataLayerInstance ParentDataLayer) { return default; }
	///<summary>Deletes all of the provided DataLayers</summary>
	public void DeleteDataLayers(TArray<UDataLayerInstance> DataLayersToDelete) {}
	///<summary>Deletes the provided DataLayer</summary>
	public void DeleteDataLayer(UDataLayerInstance DataLayerToDelete) {}
	///<summary>Returns all Data Layers</summary>
	public TArray<UDataLayerInstance> GetAllDataLayers() { return default; }
	///<summary>UpdateAllViewVisibility</summary>
	public void UpdateAllViewVisibility(UDEPRECATED_DataLayer DataLayerThatChanged) {}
	///<summary>UpdateActorAllViewsVisibility</summary>
	public void UpdateActorAllViewsVisibility(AActor Actor) {}
	///<summary>SetDataLayerIsDynamicallyLoadedInEditor</summary>
	public bool SetDataLayerIsDynamicallyLoadedInEditor(UDEPRECATED_DataLayer DataLayer,bool bIsLoadedInEditor,bool bIsFromUserChange) { return default; }
	///<summary>SetDataLayersIsDynamicallyLoadedInEditor</summary>
	public bool SetDataLayersIsDynamicallyLoadedInEditor(TArray<UDEPRECATED_DataLayer> DataLayers,bool bIsLoadedInEditor,bool bIsFromUserChange) { return default; }
	///<summary>ToggleDataLayerIsDynamicallyLoadedInEditor</summary>
	public bool ToggleDataLayerIsDynamicallyLoadedInEditor(UDEPRECATED_DataLayer DataLayer,bool bIsFromUserChange) { return default; }
	///<summary>ToggleDataLayersIsDynamicallyLoadedInEditor</summary>
	public bool ToggleDataLayersIsDynamicallyLoadedInEditor(TArray<UDEPRECATED_DataLayer> DataLayers,bool bIsFromUserChange) { return default; }
	///<summary>GetDataLayer</summary>
	public UDataLayerInstance GetDataLayer(FActorDataLayer ActorDataLayer) { return default; }
	///<summary>GetDataLayerFromLabel</summary>
	public UDataLayerInstance GetDataLayerFromLabel(string DataLayerLabel) { return default; }
	///<summary>RenameDataLayer</summary>
	public bool RenameDataLayer(UDataLayerInstance DataLayer,string NewDataLayerLabel) { return default; }
	///<summary>CreateDataLayer</summary>
	public UDataLayerInstance CreateDataLayer(UDataLayerInstance ParentDataLayer/*=nullptr*/) { return default; }
}
