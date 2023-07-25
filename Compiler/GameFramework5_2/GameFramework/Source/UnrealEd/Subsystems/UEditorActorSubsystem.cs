#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Subsystems/EditorActorSubsystem.h")]
///<summary>UEditorActorUtilitiesSubsystem</summary>
public partial class UEditorActorSubsystem : UEditorSubsystem {
// EditorActorSubsystem
	public FOnEditNewActorsDropped OnNewActorsDropped;
	public FOnEditNewActorsPlaced OnNewActorsPlaced;
	public FOnEditCutActorsBegin OnEditCutActorsBegin;
	public FOnEditCutActorsEnd OnEditCutActorsEnd;
	public FOnEditCopyActorsBegin OnEditCopyActorsBegin;
	public FOnEditCopyActorsEnd OnEditCopyActorsEnd;
	public FOnEditPasteActorsBegin OnEditPasteActorsBegin;
	public FOnEditPasteActorsEnd OnEditPasteActorsEnd;
	public FOnEditCutActorsBegin OnDuplicateActorsBegin;
	public FOnDuplicateActorsEnd OnDuplicateActorsEnd;
	public FOnDeleteActorsBegin OnDeleteActorsBegin;
	public FOnDeleteActorsEnd OnDeleteActorsEnd;
	public UObject DuplicateActor(UObject ActorToDuplicate,UObject ToWorld/*=nullptr*/,FVector Offset/*=FVector.ZeroVector*/) { return default; }
	public TArray<UObject> DuplicateActors(TArray<UObject> ActorsToDuplicate,UObject ToWorld/*=nullptr*/,FVector Offset/*=FVector.ZeroVector*/) { return default; }
	public void DuplicateSelectedActors(UObject InWorld) {}
	public void DeleteSelectedActors(UObject InWorld) {}
	public void InvertSelection(UObject InWorld) {}
	public void SelectAll(UObject InWorld) {}
	public void SelectAllChildren(bool bRecurseChildren) {}
	public TArray<UObject> GetAllLevelActors() { return default; }
	public TArray<UObject> GetAllLevelActorsComponents() { return default; }
	public TArray<UObject> GetSelectedLevelActors() { return default; }
	public void SetSelectedLevelActors(TArray<UObject> ActorsToSelect) {}
	public void ClearActorSelectionSet() {}
	public void SelectNothing() {}
	public void SetActorSelectionState(UObject Actor,bool bShouldBeSelected) {}
	public UObject GetActorReference(string PathToActor) { return default; }
	public UObject SpawnActorFromObject(UObject ObjectToUse,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bTransient/*=false*/) { return default; }
	public UObject SpawnActorFromClass(UClass ActorClass,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bTransient/*=false*/) { return default; }
	public bool DestroyActor(UObject ActorToDestroy) { return default; }
	public bool DestroyActors(TArray<UObject> ActorsToDestroy) { return default; }
	public TArray<UObject> ConvertActors(TArray<UObject> Actors,UClass ActorClass,string StaticMeshPackagePath) { return default; }
	public bool SetActorTransform(UObject InActor,FTransform InWorldTransform) { return default; }
	public bool SetComponentTransform(UObject InSceneComponent,FTransform InWorldTransform) { return default; }
}
