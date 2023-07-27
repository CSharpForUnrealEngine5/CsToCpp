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
	public  AActor DuplicateActor(AActor ActorToDuplicate,UWorld ToWorld/*=nullptr*/,FVector Offset/*=FVector.ZeroVector*/) { return default; }
	public  TArray<AActor> DuplicateActors(TArray<AActor> ActorsToDuplicate,UWorld ToWorld/*=nullptr*/,FVector Offset/*=FVector.ZeroVector*/) { return default; }
	public  void DuplicateSelectedActors(UWorld InWorld) {}
	public  void DeleteSelectedActors(UWorld InWorld) {}
	public  void InvertSelection(UWorld InWorld) {}
	public  void SelectAll(UWorld InWorld) {}
	public  void SelectAllChildren(bool bRecurseChildren) {}
	public  TArray<AActor> GetAllLevelActors() { return default; }
	public  TArray<UActorComponent> GetAllLevelActorsComponents() { return default; }
	public  TArray<AActor> GetSelectedLevelActors() { return default; }
	public  void SetSelectedLevelActors(TArray<AActor> ActorsToSelect) {}
	public  void ClearActorSelectionSet() {}
	public  void SelectNothing() {}
	public  void SetActorSelectionState(AActor Actor,bool bShouldBeSelected) {}
	public  AActor GetActorReference(string PathToActor) { return default; }
	public  AActor SpawnActorFromObject(UObject ObjectToUse,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bTransient/*=false*/) { return default; }
	public  AActor SpawnActorFromClass(UClass ActorClass,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bTransient/*=false*/) { return default; }
	public  bool DestroyActor(AActor ActorToDestroy) { return default; }
	public  bool DestroyActors(TArray<AActor> ActorsToDestroy) { return default; }
	public  TArray<AActor> ConvertActors(TArray<AActor> Actors,UClass ActorClass,string StaticMeshPackagePath) { return default; }
	public  bool SetActorTransform(AActor InActor,FTransform InWorldTransform) { return default; }
	public  bool SetComponentTransform(USceneComponent InSceneComponent,FTransform InWorldTransform) { return default; }
}
