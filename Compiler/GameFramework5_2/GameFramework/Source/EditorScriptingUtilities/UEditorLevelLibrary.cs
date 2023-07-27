#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorLevelLibrary.h")]
///<summary>Utility class to do most of the common functionalities in the World Editor.</summary>
public partial class UEditorLevelLibrary : UBlueprintFunctionLibrary {
// EditorLevelLibrary
	public static TArray<AActor> GetAllLevelActors() { return default; }
	public static TArray<UActorComponent> GetAllLevelActorsComponents() { return default; }
	public static TArray<AActor> GetSelectedLevelActors() { return default; }
	public static void SetSelectedLevelActors(TArray<AActor> ActorsToSelect) {}
	public static void PilotLevelActor(AActor ActorToPilot) {}
	public static void EjectPilotLevelActor() {}
	public static void EditorPlaySimulate() {}
	public static void EditorEndPlay() {}
	public static void EditorInvalidateViewports() {}
	public static void ReplaceSelectedActors(string InAssetPath) {}
	public static bool GetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) { return default; }
	public static void SetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) {}
	public static void ClearActorSelectionSet() {}
	public static void SelectNothing() {}
	public static void SetActorSelectionState(AActor Actor,bool bShouldBeSelected) {}
	public static AActor GetActorReference(string PathToActor) { return default; }
	public static void EditorSetGameView(bool bGameView) {}
	public static AActor SpawnActorFromObject(UObject ObjectToUse,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bTransient/*=false*/) { return default; }
	public static AActor SpawnActorFromClass(UClass ActorClass,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bTransient/*=false*/) { return default; }
	public static bool DestroyActor(AActor ActorToDestroy) { return default; }
	public static UWorld GetEditorWorld() { return default; }
	public static UWorld GetGameWorld() { return default; }
	public static TArray<UWorld> GetPIEWorlds(bool bIncludeDedicatedServer) { return default; }
	public static bool NewLevel(string AssetPath) { return default; }
	public static bool NewLevelFromTemplate(string AssetPath,string TemplateAssetPath) { return default; }
	public static bool LoadLevel(string AssetPath) { return default; }
	public static bool SaveCurrentLevel() { return default; }
	public static bool SaveAllDirtyLevels() { return default; }
	public static bool SetCurrentLevelByName(string LevelName) { return default; }
	public static void ReplaceMeshComponentsMaterials(TArray<UMeshComponent> MeshComponents,UMaterialInterface MaterialToBeReplaced,UMaterialInterface NewMaterial) {}
	public static void ReplaceMeshComponentsMaterialsOnActors(TArray<AActor> Actors,UMaterialInterface MaterialToBeReplaced,UMaterialInterface NewMaterial) {}
	public static void ReplaceMeshComponentsMeshes(TArray<UStaticMeshComponent> MeshComponents,UStaticMesh MeshToBeReplaced,UStaticMesh NewMesh) {}
	public static void ReplaceMeshComponentsMeshesOnActors(TArray<AActor> Actors,UStaticMesh MeshToBeReplaced,UStaticMesh NewMesh) {}
	public static TArray<AActor> ConvertActors(TArray<AActor> Actors,UClass ActorClass,string StaticMeshPackagePath) { return default; }
	public static AActor JoinStaticMeshActors(TArray<AStaticMeshActor> ActorsToJoin,FJoinStaticMeshActorsOptions JoinOptions) { return default; }
	public static bool MergeStaticMeshActors(TArray<AStaticMeshActor> ActorsToMerge,FMergeStaticMeshActorsOptions MergeOptions,AStaticMeshActor OutMergedActor) { return default; }
	public static bool CreateProxyMeshActor(TArray<AStaticMeshActor> ActorsToMerge,FCreateProxyMeshActorOptions MergeOptions,AStaticMeshActor OutMergedActor) { return default; }
}
