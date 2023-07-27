#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Layers/LayersSubsystem.h")]
public partial class ULayersSubsystem : UEditorSubsystem {
// LayersSubsystem
	public  void AddLevelLayerInformation(ULevel Level) {}
	public  void RemoveLevelLayerInformation(ULevel Level) {}
	public  bool IsActorValidForLayer(AActor Actor) { return default; }
	public  bool InitializeNewActorLayers(AActor Actor) { return default; }
	public  bool DisassociateActorFromLayers(AActor Actor) { return default; }
	public  bool AddActorToLayer(AActor Actor,string LayerName) { return default; }
	public  bool AddActorToLayers(AActor Actor,TArray<string> LayerNames) { return default; }
	public  bool RemoveActorFromLayer(AActor Actor,string LayerToRemove,bool bUpdateStats/*=true*/) { return default; }
	public  bool RemoveActorFromLayers(AActor Actor,TArray<string> LayerNames,bool bUpdateStats/*=true*/) { return default; }
	public  bool AddActorsToLayer(TArray<AActor> Actors,string LayerName) { return default; }
	public  bool AddActorsToLayers(TArray<AActor> Actors,TArray<string> LayerNames) { return default; }
	public  bool DisassociateActorsFromLayers(TArray<AActor> Actors) { return default; }
	public  bool RemoveActorsFromLayer(TArray<AActor> Actors,string LayerName,bool bUpdateStats/*=true*/) { return default; }
	public  bool RemoveActorsFromLayers(TArray<AActor> Actors,TArray<string> LayerNames,bool bUpdateStats/*=true*/) { return default; }
	public  TArray<AActor> GetSelectedActors() { return default; }
	public  bool AddSelectedActorsToLayer(string LayerName) { return default; }
	public  bool AddSelectedActorsToLayers(TArray<string> LayerNames) { return default; }
	public  bool RemoveSelectedActorsFromLayer(string LayerName) { return default; }
	public  bool RemoveSelectedActorsFromLayers(TArray<string> LayerNames) { return default; }
	public  bool SelectActorsInLayer(string LayerName,bool bSelect,bool bNotify,bool bSelectEvenIfHidden/*=false*/) { return default; }
	public  bool SelectActorsInLayers(TArray<string> LayerNames,bool bSelect,bool bNotify,bool bSelectEvenIfHidden/*=false*/) { return default; }
	public  void UpdateAllViewVisibility(string LayerThatChanged) {}
	public  void UpdateActorAllViewsVisibility(AActor Actor) {}
	public  bool UpdateActorVisibility(AActor Actor,bool bOutSelectionChanged,bool bOutActorModified,bool bNotifySelectionChange,bool bRedrawViewports) { return default; }
	public  bool UpdateAllActorsVisibility(bool bNotifySelectionChange,bool bRedrawViewports) { return default; }
	public  void AppendActorsFromLayer(string LayerName,TArray<AActor> InOutActors) {}
	public  void AppendActorsFromLayers(TArray<string> LayerNames,TArray<AActor> InOutActors) {}
	public  TArray<AActor> GetActorsFromLayer(string LayerName) { return default; }
	public  TArray<AActor> GetActorsFromLayers(TArray<string> LayerNames) { return default; }
	public  void SetLayerVisibility(string LayerName,bool bIsVisible) {}
	public  void SetLayersVisibility(TArray<string> LayerNames,bool bIsVisible) {}
	public  void ToggleLayerVisibility(string LayerName) {}
	public  void ToggleLayersVisibility(TArray<string> LayerNames) {}
	public  void MakeAllLayersVisible() {}
	public  ULayer GetLayer(string LayerName) { return default; }
	public  bool IsLayer(string LayerName) { return default; }
	public  bool TryGetLayer(string LayerName,ULayer OutLayer) { return default; }
	public  void AddAllLayerNamesTo(TArray<string> OutLayerNames) {}
	public  void AddAllLayersTo(TArray<ULayer> OutLayers) {}
	public  ULayer CreateLayer(string LayerName) { return default; }
	public  void DeleteLayers(TArray<string> LayersToDelete) {}
	public  void DeleteLayer(string LayerToDelete) {}
	public  bool RenameLayer(string OriginalLayerName,string NewLayerName) { return default; }
	public  UWorld GetWorld() { return default; }
	public  void EditorMapChange() {}
	public  void EditorRefreshLayerBrowser() {}
}
