namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Layers/LayersSubsystem.h")]
public partial class ULayersSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Aggregates any information regarding layers associated with the level and it contents</summary>
	public virtual void AddLevelLayerInformation(ULevel Level) {}
	///<summary>Purges any information regarding layers associated with the level and it contents</summary>
	public virtual void RemoveLevelLayerInformation(ULevel Level) {}
	///<summary>Checks to see if the specified actor is in an appropriate state to interact with layers</summary>
	public virtual bool IsActorValidForLayer(AActor Actor) { return default; }
	///<summary>Synchronizes an newly created Actor&#39;s layers with the layer system</summary>
	public virtual bool InitializeNewActorLayers(AActor Actor) { return default; }
	///<summary>Disassociates an Actor&#39;s layers from the layer system, general used before deleting the Actor</summary>
	public virtual bool DisassociateActorFromLayers(AActor Actor) { return default; }
	///<summary>Adds the actor to the named layer.</summary>
	public virtual bool AddActorToLayer(AActor Actor,FName LayerName) { return default; }
	///<summary>Adds the provided actor to the named layers.</summary>
	public virtual bool AddActorToLayers(AActor Actor,TArray<FName> LayerNames) { return default; }
	///<summary>Removes an actor from the specified layer.</summary>
	public virtual bool RemoveActorFromLayer(AActor Actor,FName LayerToRemove,bool bUpdateStats/*=true*/) { return default; }
	///<summary>Removes the provided actor from the named layers.</summary>
	public virtual bool RemoveActorFromLayers(AActor Actor,TArray<FName> LayerNames,bool bUpdateStats/*=true*/) { return default; }
	///<summary>Add the actors to the named layer</summary>
	public bool AddActorsToLayer(TArray<AActor> Actors,FName LayerName) { return default; }
	///<summary>Add the actors to the named layers</summary>
	public bool AddActorsToLayers(TArray<AActor> Actors,TArray<FName> LayerNames) { return default; }
	///<summary>Disassociates actors from the layer system, generally used before deleting the Actors</summary>
	public virtual bool DisassociateActorsFromLayers(TArray<AActor> Actors) { return default; }
	///<summary>Removes the actors from the specified layer.</summary>
	public bool RemoveActorsFromLayer(TArray<AActor> Actors,FName LayerName,bool bUpdateStats/*=true*/) { return default; }
	///<summary>Remove the actors to the named layers</summary>
	public bool RemoveActorsFromLayers(TArray<AActor> Actors,TArray<FName> LayerNames,bool bUpdateStats/*=true*/) { return default; }
	///<summary>Find and return the selected actors.</summary>
	public TArray<AActor> GetSelectedActors() { return default; }
	///<summary>Adds selected actors to the named layer.</summary>
	public virtual bool AddSelectedActorsToLayer(FName LayerName) { return default; }
	///<summary>Adds selected actors to the named layers.</summary>
	public virtual bool AddSelectedActorsToLayers(TArray<FName> LayerNames) { return default; }
	///<summary>Removes the selected actors from the named layer.</summary>
	public virtual bool RemoveSelectedActorsFromLayer(FName LayerName) { return default; }
	///<summary>Removes selected actors from the named layers.</summary>
	public virtual bool RemoveSelectedActorsFromLayers(TArray<FName> LayerNames) { return default; }
	///<summary>Selects/de-selects actors belonging to the named layer.</summary>
	public bool SelectActorsInLayer(FName LayerName,bool bSelect,bool bNotify,bool bSelectEvenIfHidden/*=false*/) { return default; }
	///<summary>Selects/de-selects actors belonging to the named layers.</summary>
	public bool SelectActorsInLayers(TArray<FName> LayerNames,bool bSelect,bool bNotify,bool bSelectEvenIfHidden/*=false*/) { return default; }
	///<summary>Updates the visibility for all actors for all views.</summary>
	public virtual void UpdateAllViewVisibility(FName LayerThatChanged) {}
	///<summary>Updates per-view visibility for the given actor for all views</summary>
	public virtual void UpdateActorAllViewsVisibility(AActor Actor) {}
	///<summary>Updates the provided actors visibility in the viewports</summary>
	public virtual bool UpdateActorVisibility(AActor Actor,bool bOutSelectionChanged,bool bOutActorModified,bool bNotifySelectionChange,bool bRedrawViewports) { return default; }
	///<summary>Updates the visibility of all actors in the viewports</summary>
	public virtual bool UpdateAllActorsVisibility(bool bNotifySelectionChange,bool bRedrawViewports) { return default; }
	///<summary>Appends all the actors associated with the specified layer.</summary>
	public void AppendActorsFromLayer(FName LayerName,TArray<AActor> InOutActors) {}
	///<summary>Appends all the actors associated with ANY of the specified layers.</summary>
	public void AppendActorsFromLayers(TArray<FName> LayerNames,TArray<AActor> InOutActors) {}
	///<summary>Gets all the actors associated with the specified layer. Analog to AppendActorsFromLayer but it returns rather than appends the actors.</summary>
	public TArray<AActor> GetActorsFromLayer(FName LayerName) { return default; }
	///<summary>Gets all the actors associated with ANY of the specified layers. Analog to AppendActorsFromLayers but it returns rather than appends the actors.</summary>
	public TArray<AActor> GetActorsFromLayers(TArray<FName> LayerNames) { return default; }
	///<summary>Changes the named layer&#39;s visibility to the provided state</summary>
	public virtual void SetLayerVisibility(FName LayerName,bool bIsVisible) {}
	///<summary>Changes visibility of the named layers to the provided state</summary>
	public virtual void SetLayersVisibility(TArray<FName> LayerNames,bool bIsVisible) {}
	///<summary>Toggles the named layer&#39;s visibility</summary>
	public virtual void ToggleLayerVisibility(FName LayerName) {}
	///<summary>Toggles the visibility of all of the named layers</summary>
	public virtual void ToggleLayersVisibility(TArray<FName> LayerNames) {}
	///<summary>Set the visibility of all layers to true</summary>
	public virtual void MakeAllLayersVisible() {}
	///<summary>Gets the ULayer Object of the named layer</summary>
	public ULayer GetLayer(FName LayerName) { return default; }
	///<summary>Checks whether the ULayer Object of the provided layer name exists.</summary>
	public bool IsLayer(FName LayerName) { return default; }
	///<summary>Attempts to get the ULayer Object of the provided layer name.</summary>
	public virtual bool TryGetLayer(FName LayerName,ULayer OutLayer) { return default; }
	///<summary>Gets all known layers and appends their names to the provide array</summary>
	public virtual void AddAllLayerNamesTo(TArray<FName> OutLayerNames) {}
	///<summary>Gets all known layers and appends them to the provided array</summary>
	public virtual void AddAllLayersTo(TArray<ULayer> OutLayers) {}
	///<summary>Creates a ULayer Object for the named layer</summary>
	public ULayer CreateLayer(FName LayerName) { return default; }
	///<summary>Deletes all of the provided layers, disassociating all actors from them</summary>
	public virtual void DeleteLayers(TArray<FName> LayersToDelete) {}
	///<summary>Deletes the provided layer, disassociating all actors from them</summary>
	public virtual void DeleteLayer(FName LayerToDelete) {}
	///<summary>Renames the provided originally named layer to the provided new name</summary>
	public virtual bool RenameLayer(FName OriginalLayerName,FName NewLayerName) { return default; }
	///<summary>Get the current UWorld object.</summary>
	public UWorld GetWorld() { return default; }
	///<summary>Delegate handler for FEditorDelegates::MapChange. It internally calls LayersChanged.Broadcast.</summary>
	public void EditorMapChange() {}
	///<summary>Delegate handler for FEditorDelegates::RefreshLayerBrowser. It internally calls UpdateAllActorsVisibility to refresh the actors of each layer.</summary>
	public void EditorRefreshLayerBrowser() {}
}
