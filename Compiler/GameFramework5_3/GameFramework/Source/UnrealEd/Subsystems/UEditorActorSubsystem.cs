namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UEditorActorUtilitiesSubsystem</summary>
[CppInclude("Subsystems/EditorActorSubsystem.h")]
public partial class UEditorActorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>OnNewActorsDropped</summary>
	public FOnEditNewActorsDropped OnNewActorsDropped;
	///<summary>OnNewActorsPlaced</summary>
	public FOnEditNewActorsPlaced OnNewActorsPlaced;
	///<summary>OnEditCutActorsBegin</summary>
	public FOnEditCutActorsBegin OnEditCutActorsBegin;
	///<summary>OnEditCutActorsEnd</summary>
	public FOnEditCutActorsEnd OnEditCutActorsEnd;
	///<summary>OnEditCopyActorsBegin</summary>
	public FOnEditCopyActorsBegin OnEditCopyActorsBegin;
	///<summary>OnEditCopyActorsEnd</summary>
	public FOnEditCopyActorsEnd OnEditCopyActorsEnd;
	///<summary>OnEditPasteActorsBegin</summary>
	public FOnEditPasteActorsBegin OnEditPasteActorsBegin;
	///<summary>OnEditPasteActorsEnd</summary>
	public FOnEditPasteActorsEnd OnEditPasteActorsEnd;
	///<summary>OnDuplicateActorsBegin</summary>
	public FOnEditCutActorsBegin OnDuplicateActorsBegin;
	///<summary>OnDuplicateActorsEnd</summary>
	public FOnDuplicateActorsEnd OnDuplicateActorsEnd;
	///<summary>OnDeleteActorsBegin</summary>
	public FOnDeleteActorsBegin OnDeleteActorsBegin;
	///<summary>OnDeleteActorsEnd</summary>
	public FOnDeleteActorsEnd OnDeleteActorsEnd;
	///<summary>Duplicate an actor from the world editor.</summary>
	public AActor DuplicateActor(AActor ActorToDuplicate,UWorld ToWorld/*=nullptr*/,FVector Offset/*=FVector.ZeroVector*/) { return default; }
	///<summary>Duplicate actors from the world editor.</summary>
	public TArray<AActor> DuplicateActors(TArray<AActor> ActorsToDuplicate,UWorld ToWorld/*=nullptr*/,FVector Offset/*=FVector.ZeroVector*/) { return default; }
	///<summary>Duplicate all the selected actors in the given world</summary>
	public void DuplicateSelectedActors(UWorld InWorld) {}
	///<summary>Delete all the selected actors in the given world</summary>
	public void DeleteSelectedActors(UWorld InWorld) {}
	///<summary>Invert the selection in the given world</summary>
	public void InvertSelection(UWorld InWorld) {}
	///<summary>Select all actors and BSP models in the given world, except those which are hidden</summary>
	public void SelectAll(UWorld InWorld) {}
	///<summary>Select all children actors of the current selection.</summary>
	public void SelectAllChildren(bool bRecurseChildren) {}
	///<summary>Find all loaded Actors in the world editor. Exclude actor that are pending kill, in PIE, PreviewEditor, ...</summary>
	public TArray<AActor> GetAllLevelActors() { return default; }
	///<summary>Find all loaded ActorComponent own by an actor in the world editor. Exclude actor that are pending kill, in PIE, PreviewEditor, ...</summary>
	public TArray<UActorComponent> GetAllLevelActorsComponents() { return default; }
	///<summary>Find all loaded Actors that are selected in the world editor. Exclude actor that are pending kill, in PIE, PreviewEditor, ...</summary>
	public TArray<AActor> GetSelectedLevelActors() { return default; }
	///<summary>Clear the current world editor selection and select the provided actors. Exclude actor that are pending kill, in PIE, PreviewEditor, ...</summary>
	public void SetSelectedLevelActors(TArray<AActor> ActorsToSelect) {}
	///<summary>Remove all actors from the selection set</summary>
	public void ClearActorSelectionSet() {}
	///<summary>Selects nothing in the editor (another way to clear the selection)</summary>
	public void SelectNothing() {}
	///<summary>Set the selection state for the selected actor</summary>
	public void SetActorSelectionState(AActor Actor,bool bShouldBeSelected) {}
	///<summary>Attempts to find the actor specified by PathToActor in the current editor world</summary>
	public AActor GetActorReference(string PathToActor) { return default; }
	///<summary>Create an actor and place it in the world editor. The Actor can be created from a Factory, Archetype, Blueprint, Class or an Asset.</summary>
	public AActor SpawnActorFromObject(UObject ObjectToUse,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bTransient/*=false*/) { return default; }
	///<summary>Create an actor and place it in the world editor. Can be created from a Blueprint or a Class.</summary>
	public AActor SpawnActorFromClass(UClass ActorClass,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bTransient/*=false*/) { return default; }
	///<summary>Destroy the actor from the world editor. Notify the Editor that the actor got destroyed.</summary>
	public bool DestroyActor(AActor ActorToDestroy) { return default; }
	///<summary>Destroy the actors from the world editor. Notify the Editor that the actor got destroyed.</summary>
	public bool DestroyActors(TArray<AActor> ActorsToDestroy) { return default; }
	///<summary>Replace in the level all Actors provided with a new actor of type ActorClass. Destroy all Actors provided.</summary>
	public TArray<AActor> ConvertActors(TArray<AActor> Actors,UClass ActorClass,string StaticMeshPackagePath) { return default; }
	///<summary>Sets the world transform of the given actor, if possible.</summary>
	public bool SetActorTransform(AActor InActor,FTransform InWorldTransform) { return default; }
	///<summary>Sets the world transform of the given component, if possible.</summary>
	public bool SetComponentTransform(USceneComponent InSceneComponent,FTransform InWorldTransform) { return default; }
}
