namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Functionality added to prototype the VR scouting tools</summary>
[CppInclude("VPBlueprintLibrary.h")]
public partial class UVPBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Refresh the desktop 3D viewport so that it updates changes even when not set to &#39;Realtime&#39;</summary>
	public static void Refresh3DEditorViewport() {}
	///<summary>Spawn a virtual production tickable actor</summary>
	public static AVPViewportTickableActorBase SpawnVPTickableActor(UObject ContextObject,UClass ActorClass,FVector Location,FRotator Rotation) { return default; }
	///<summary>Spawn a virtual production bookmark</summary>
	public static AActor SpawnBookmarkAtCurrentLevelEditorPosition(UClass ActorClass,FVPBookmarkCreationContext CreationContext,FVector Offset,bool bFlattenRotation/*=true*/) { return default; }
	///<summary>Jump to a virtual production bookmark</summary>
	public static bool JumpToBookmarkInLevelEditor(UVPBookmark Bookmark) { return default; }
	///<summary>The machine role(s) in a virtual production context.</summary>
	public static FGameplayTagContainer GetVirtualProductionRole() { return default; }
	///<summary>Get the location of the 2D viewport camera</summary>
	public static FTransform GetEditorViewportTransform() { return default; }
	///<summary>Get the location of the VR HMD</summary>
	public static FTransform GetEditorVRHeadTransform() { return default; }
	///<summary>Get the VR room transform (the playable area shown as a wireframe cage on Vive and Rift</summary>
	public static FTransform GetEditorVRRoomTransform() { return default; }
	///<summary>Set the VR grab speed cvar</summary>
	public static void SetGrabSpeed(float Speed) {}
	///<summary>Get whether the user is in editor VR mode</summary>
	public static bool IsVREditorModeActive() { return default; }
	///<summary>Get the hitlocation of the interaction controller&#39;s laser pointer, in world space</summary>
	public static FVector GetVREditorLaserHoverLocation() { return default; }
	///<summary>Trigger an UnrealEd Undo</summary>
	public static bool EditorUndo() { return default; }
	///<summary>Trigger an UnrealEd Redo</summary>
	public static bool EditorRedo() { return default; }
	///<summary>Trigger an UnrealEd Duplicate</summary>
	public static bool EditorDuplicate() { return default; }
	///<summary>Trigger an UnrealEd Delete</summary>
	public static bool EditorDeleteSelectedObjects() { return default; }
	///<summary>Wrapper around UUnrealEditorSubsystem::GetEditorWorld.</summary>
	public static UWorld GetEditorWorld() { return default; }
	///<summary>VPBookmarkSplineMeshIndicatorSetStartAndEnd</summary>
	public static void VPBookmarkSplineMeshIndicatorSetStartAndEnd(USplineMeshComponent SplineMesh) {}
	///<summary>VPBookmarkSplineMeshIndicatorDisable</summary>
	public static void VPBookmarkSplineMeshIndicatorDisable(USplineMeshComponent SplineMesh) {}
}
