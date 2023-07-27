#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBlueprintLibrary.h")]
///<summary>Functionality added to prototype the VR scouting tools</summary>
public partial class UVPBlueprintLibrary : UBlueprintFunctionLibrary {
// VPBlueprintLibrary
	public static void Refresh3DEditorViewport() {}
	public static AVPViewportTickableActorBase SpawnVPTickableActor(UObject ContextObject,UClass ActorClass,FVector Location,FRotator Rotation) { return default; }
	public static AActor SpawnBookmarkAtCurrentLevelEditorPosition(UClass ActorClass,FVPBookmarkCreationContext CreationContext,FVector Offset,bool bFlattenRotation/*=true*/) { return default; }
	public static bool JumpToBookmarkInLevelEditor(UVPBookmark Bookmark) { return default; }
	public static FGameplayTagContainer GetVirtualProductionRole() { return default; }
	public static FTransform GetEditorViewportTransform() { return default; }
	public static FTransform GetEditorVRHeadTransform() { return default; }
	public static FTransform GetEditorVRRoomTransform() { return default; }
	public static void SetGrabSpeed(float Speed) {}
	public static bool IsVREditorModeActive() { return default; }
	public static FVector GetVREditorLaserHoverLocation() { return default; }
	public static bool EditorUndo() { return default; }
	public static bool EditorRedo() { return default; }
	public static bool EditorDuplicate() { return default; }
	public static bool EditorDeleteSelectedObjects() { return default; }
	public static UWorld GetEditorWorld() { return default; }
	public static void VPBookmarkSplineMeshIndicatorSetStartAndEnd(USplineMeshComponent SplineMesh) {}
	public static void VPBookmarkSplineMeshIndicatorDisable(USplineMeshComponent SplineMesh) {}
}
