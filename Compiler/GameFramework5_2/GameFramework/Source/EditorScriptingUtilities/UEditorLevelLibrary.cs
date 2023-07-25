#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorLevelLibrary.h")]
///<summary>Utility class to do most of the common functionalities in the World Editor.</summary>
public partial class UEditorLevelLibrary : UBlueprintFunctionLibrary {
// EditorLevelLibrary
	public TArray<UObject> GetAllLevelActors() { return default; }
	public TArray<UObject> GetAllLevelActorsComponents() { return default; }
	public TArray<UObject> GetSelectedLevelActors() { return default; }
	public void SetSelectedLevelActors(TArray<UObject> ActorsToSelect) {}
	public void PilotLevelActor(UObject ActorToPilot) {}
	public void EjectPilotLevelActor() {}
	public void EditorPlaySimulate() {}
	public void EditorEndPlay() {}
	public void EditorInvalidateViewports() {}
	public void ReplaceSelectedActors(string InAssetPath) {}
	public bool GetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) { return default; }
	public void SetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) {}
	public void ClearActorSelectionSet() {}
	public void SelectNothing() {}
	public void SetActorSelectionState(UObject Actor,bool bShouldBeSelected) {}
	public UObject GetActorReference(string PathToActor) { return default; }
	public void EditorSetGameView(bool bGameView) {}
	public UObject SpawnActorFromObject(UObject ObjectToUse,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bTransient/*=false*/) { return default; }
	public UObject SpawnActorFromClass(UClass ActorClass,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bTransient/*=false*/) { return default; }
	public bool DestroyActor(UObject ActorToDestroy) { return default; }
	public UObject GetEditorWorld() { return default; }
	public UObject GetGameWorld() { return default; }
	public TArray<UObject> GetPIEWorlds(bool bIncludeDedicatedServer) { return default; }
	public bool NewLevel(string AssetPath) { return default; }
	public bool NewLevelFromTemplate(string AssetPath,string TemplateAssetPath) { return default; }
	public bool LoadLevel(string AssetPath) { return default; }
	public bool SaveCurrentLevel() { return default; }
	public bool SaveAllDirtyLevels() { return default; }
	public bool SetCurrentLevelByName(string LevelName) { return default; }
	public void ReplaceMeshComponentsMaterials(TArray<UObject> MeshComponents,UObject MaterialToBeReplaced,UObject NewMaterial) {}
	public void ReplaceMeshComponentsMaterialsOnActors(TArray<UObject> Actors,UObject MaterialToBeReplaced,UObject NewMaterial) {}
	public void ReplaceMeshComponentsMeshes(TArray<UObject> MeshComponents,UObject MeshToBeReplaced,UObject NewMesh) {}
	public void ReplaceMeshComponentsMeshesOnActors(TArray<UObject> Actors,UObject MeshToBeReplaced,UObject NewMesh) {}
	public TArray<UObject> ConvertActors(TArray<UObject> Actors,UClass ActorClass,string StaticMeshPackagePath) { return default; }
	public UObject JoinStaticMeshActors(TArray<UObject> ActorsToJoin,FJoinStaticMeshActorsOptions JoinOptions) { return default; }
	public bool MergeStaticMeshActors(TArray<UObject> ActorsToMerge,FMergeStaticMeshActorsOptions MergeOptions,UObject OutMergedActor) { return default; }
	public bool CreateProxyMeshActor(TArray<UObject> ActorsToMerge,FCreateProxyMeshActorOptions MergeOptions,UObject OutMergedActor) { return default; }
}
