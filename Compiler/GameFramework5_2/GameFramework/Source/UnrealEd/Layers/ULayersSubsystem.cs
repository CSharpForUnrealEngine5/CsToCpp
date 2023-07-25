#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Layers/LayersSubsystem.h")]
public partial class ULayersSubsystem : UEditorSubsystem {
// LayersSubsystem
	public void AddLevelLayerInformation(UObject Level) {}
	public void RemoveLevelLayerInformation(UObject Level) {}
	public bool IsActorValidForLayer(UObject Actor) { return default; }
	public bool InitializeNewActorLayers(UObject Actor) { return default; }
	public bool DisassociateActorFromLayers(UObject Actor) { return default; }
	public bool AddActorToLayer(UObject Actor,string LayerName) { return default; }
	public bool AddActorToLayers(UObject Actor,TArray<string> LayerNames) { return default; }
	public bool RemoveActorFromLayer(UObject Actor,string LayerToRemove,bool bUpdateStats/*=true*/) { return default; }
	public bool RemoveActorFromLayers(UObject Actor,TArray<string> LayerNames,bool bUpdateStats/*=true*/) { return default; }
	public bool AddActorsToLayer(TArray<UObject> Actors,string LayerName) { return default; }
	public bool AddActorsToLayers(TArray<UObject> Actors,TArray<string> LayerNames) { return default; }
	public bool DisassociateActorsFromLayers(TArray<UObject> Actors) { return default; }
	public bool RemoveActorsFromLayer(TArray<UObject> Actors,string LayerName,bool bUpdateStats/*=true*/) { return default; }
	public bool RemoveActorsFromLayers(TArray<UObject> Actors,TArray<string> LayerNames,bool bUpdateStats/*=true*/) { return default; }
	public TArray<UObject> GetSelectedActors() { return default; }
	public bool AddSelectedActorsToLayer(string LayerName) { return default; }
	public bool AddSelectedActorsToLayers(TArray<string> LayerNames) { return default; }
	public bool RemoveSelectedActorsFromLayer(string LayerName) { return default; }
	public bool RemoveSelectedActorsFromLayers(TArray<string> LayerNames) { return default; }
	public bool SelectActorsInLayer(string LayerName,bool bSelect,bool bNotify,bool bSelectEvenIfHidden/*=false*/) { return default; }
	public bool SelectActorsInLayers(TArray<string> LayerNames,bool bSelect,bool bNotify,bool bSelectEvenIfHidden/*=false*/) { return default; }
	public void UpdateAllViewVisibility(string LayerThatChanged) {}
	public void UpdateActorAllViewsVisibility(UObject Actor) {}
	public bool UpdateActorVisibility(UObject Actor,bool bOutSelectionChanged,bool bOutActorModified,bool bNotifySelectionChange,bool bRedrawViewports) { return default; }
	public bool UpdateAllActorsVisibility(bool bNotifySelectionChange,bool bRedrawViewports) { return default; }
	public void AppendActorsFromLayer(string LayerName,TArray<UObject> InOutActors) {}
	public void AppendActorsFromLayers(TArray<string> LayerNames,TArray<UObject> InOutActors) {}
	public TArray<UObject> GetActorsFromLayer(string LayerName) { return default; }
	public TArray<UObject> GetActorsFromLayers(TArray<string> LayerNames) { return default; }
	public void SetLayerVisibility(string LayerName,bool bIsVisible) {}
	public void SetLayersVisibility(TArray<string> LayerNames,bool bIsVisible) {}
	public void ToggleLayerVisibility(string LayerName) {}
	public void ToggleLayersVisibility(TArray<string> LayerNames) {}
	public void MakeAllLayersVisible() {}
	public UObject GetLayer(string LayerName) { return default; }
	public bool IsLayer(string LayerName) { return default; }
	public bool TryGetLayer(string LayerName,UObject OutLayer) { return default; }
	public void AddAllLayerNamesTo(TArray<string> OutLayerNames) {}
	public void AddAllLayersTo(TArray<UObject> OutLayers) {}
	public UObject CreateLayer(string LayerName) { return default; }
	public void DeleteLayers(TArray<string> LayersToDelete) {}
	public void DeleteLayer(string LayerToDelete) {}
	public bool RenameLayer(string OriginalLayerName,string NewLayerName) { return default; }
	public UObject GetWorld() { return default; }
	public void EditorMapChange() {}
	public void EditorRefreshLayerBrowser() {}
}
