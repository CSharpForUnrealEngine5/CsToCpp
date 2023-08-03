#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility class to do most of the common functionalities in the World Editor.</summary>
[CppInclude("EditorLevelLibrary.h")]
public partial class UEditorLevelLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetAllLevelActors</summary>
	public static TArray<AActor> GetAllLevelActors() { return default; }
	///<summary>GetAllLevelActorsComponents</summary>
	public static TArray<UActorComponent> GetAllLevelActorsComponents() { return default; }
	///<summary>GetSelectedLevelActors</summary>
	public static TArray<AActor> GetSelectedLevelActors() { return default; }
	///<summary>SetSelectedLevelActors</summary>
	public static void SetSelectedLevelActors(TArray<AActor> ActorsToSelect) {}
	///<summary>PilotLevelActor</summary>
	public static void PilotLevelActor(AActor ActorToPilot) {}
	///<summary>EjectPilotLevelActor</summary>
	public static void EjectPilotLevelActor() {}
	///<summary>EditorPlaySimulate</summary>
	public static void EditorPlaySimulate() {}
	///<summary>EditorEndPlay</summary>
	public static void EditorEndPlay() {}
	///<summary>EditorInvalidateViewports</summary>
	public static void EditorInvalidateViewports() {}
	///<summary>Replaces the selected Actors with the same number of a different kind of Actor using the specified factory to spawn the new Actors</summary>
	public static void ReplaceSelectedActors(string InAssetPath) {}
	///<summary>GetLevelViewportCameraInfo</summary>
	public static bool GetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) { return default; }
	///<summary>SetLevelViewportCameraInfo</summary>
	public static void SetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) {}
	///<summary>ClearActorSelectionSet</summary>
	public static void ClearActorSelectionSet() {}
	///<summary>SelectNothing</summary>
	public static void SelectNothing() {}
	///<summary>SetActorSelectionState</summary>
	public static void SetActorSelectionState(AActor Actor,bool bShouldBeSelected) {}
	///<summary>GetActorReference</summary>
	public static AActor GetActorReference(string PathToActor) { return default; }
	///<summary>EditorSetGameView</summary>
	public static void EditorSetGameView(bool bGameView) {}
	///<summary>SpawnActorFromObject</summary>
	public static AActor SpawnActorFromObject(UObject ObjectToUse,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bTransient/*=false*/) { return default; }
	///<summary>SpawnActorFromClass</summary>
	public static AActor SpawnActorFromClass(UClass ActorClass,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bTransient/*=false*/) { return default; }
	///<summary>DestroyActor</summary>
	public static bool DestroyActor(AActor ActorToDestroy) { return default; }
	///<summary>GetEditorWorld</summary>
	public static UWorld GetEditorWorld() { return default; }
	///<summary>GetGameWorld</summary>
	public static UWorld GetGameWorld() { return default; }
	///<summary>GetPIEWorlds</summary>
	public static TArray<UWorld> GetPIEWorlds(bool bIncludeDedicatedServer) { return default; }
	///<summary>NewLevel</summary>
	public static bool NewLevel(string AssetPath) { return default; }
	///<summary>NewLevelFromTemplate</summary>
	public static bool NewLevelFromTemplate(string AssetPath,string TemplateAssetPath) { return default; }
	///<summary>LoadLevel</summary>
	public static bool LoadLevel(string AssetPath) { return default; }
	///<summary>SaveCurrentLevel</summary>
	public static bool SaveCurrentLevel() { return default; }
	///<summary>SaveAllDirtyLevels</summary>
	public static bool SaveAllDirtyLevels() { return default; }
	///<summary>SetCurrentLevelByName</summary>
	public static bool SetCurrentLevelByName(string LevelName) { return default; }
	///<summary>ReplaceMeshComponentsMaterials</summary>
	public static void ReplaceMeshComponentsMaterials(TArray<UMeshComponent> MeshComponents,UMaterialInterface MaterialToBeReplaced,UMaterialInterface NewMaterial) {}
	///<summary>ReplaceMeshComponentsMaterialsOnActors</summary>
	public static void ReplaceMeshComponentsMaterialsOnActors(TArray<AActor> Actors,UMaterialInterface MaterialToBeReplaced,UMaterialInterface NewMaterial) {}
	///<summary>ReplaceMeshComponentsMeshes</summary>
	public static void ReplaceMeshComponentsMeshes(TArray<UStaticMeshComponent> MeshComponents,UStaticMesh MeshToBeReplaced,UStaticMesh NewMesh) {}
	///<summary>ReplaceMeshComponentsMeshesOnActors</summary>
	public static void ReplaceMeshComponentsMeshesOnActors(TArray<AActor> Actors,UStaticMesh MeshToBeReplaced,UStaticMesh NewMesh) {}
	///<summary>ConvertActors</summary>
	public static TArray<AActor> ConvertActors(TArray<AActor> Actors,UClass ActorClass,string StaticMeshPackagePath) { return default; }
	///<summary>JoinStaticMeshActors</summary>
	public static AActor JoinStaticMeshActors(TArray<AStaticMeshActor> ActorsToJoin,FJoinStaticMeshActorsOptions JoinOptions) { return default; }
	///<summary>MergeStaticMeshActors</summary>
	public static bool MergeStaticMeshActors(TArray<AStaticMeshActor> ActorsToMerge,FMergeStaticMeshActorsOptions MergeOptions,AStaticMeshActor OutMergedActor) { return default; }
	///<summary>CreateProxyMeshActor</summary>
	public static bool CreateProxyMeshActor(TArray<AStaticMeshActor> ActorsToMerge,FCreateProxyMeshActorOptions MergeOptions,AStaticMeshActor OutMergedActor) { return default; }
}
