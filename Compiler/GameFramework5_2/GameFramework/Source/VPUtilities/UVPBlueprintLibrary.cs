#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBlueprintLibrary.h")]
///<summary>Functionality added to prototype the VR scouting tools</summary>
public partial class UVPBlueprintLibrary : UBlueprintFunctionLibrary {
// VPBlueprintLibrary
	public void Refresh3DEditorViewport() {}
	public UObject SpawnVPTickableActor(UObject ContextObject,UClass ActorClass,FVector Location,FRotator Rotation) { return default; }
	public UObject SpawnBookmarkAtCurrentLevelEditorPosition(UClass ActorClass,FVPBookmarkCreationContext CreationContext,FVector Offset,bool bFlattenRotation/*=true*/) { return default; }
	public bool JumpToBookmarkInLevelEditor(UObject Bookmark) { return default; }
	public FGameplayTagContainer GetVirtualProductionRole() { return default; }
	public FTransform GetEditorViewportTransform() { return default; }
	public FTransform GetEditorVRHeadTransform() { return default; }
	public FTransform GetEditorVRRoomTransform() { return default; }
	public void SetGrabSpeed(float Speed) {}
	public bool IsVREditorModeActive() { return default; }
	public FVector GetVREditorLaserHoverLocation() { return default; }
	public bool EditorUndo() { return default; }
	public bool EditorRedo() { return default; }
	public bool EditorDuplicate() { return default; }
	public bool EditorDeleteSelectedObjects() { return default; }
	public UObject GetEditorWorld() { return default; }
	public void VPBookmarkSplineMeshIndicatorSetStartAndEnd(UObject SplineMesh) {}
	public void VPBookmarkSplineMeshIndicatorDisable(UObject SplineMesh) {}
}
