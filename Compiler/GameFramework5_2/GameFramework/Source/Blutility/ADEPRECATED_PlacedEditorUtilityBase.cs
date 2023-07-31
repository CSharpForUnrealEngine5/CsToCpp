#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PlacedEditorUtilityBase.h")]
public partial class ADEPRECATED_PlacedEditorUtilityBase : AActor {
	///<summary>HelpText</summary>
	public string HelpText;
	///<summary>Returns the current selection set in the editor.  Note that for non-editor builds, this will return an empty array</summary>
	public  TArray<AActor> GetSelectionSet() { return default; }
	///<summary>Gets information about the camera position for the primary level editor viewport.  In non-editor builds, these will be zeroed</summary>
	public  bool GetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) { return default; }
	///<summary>Sets information about the camera position for the primary level editor viewport.</summary>
	public  void SetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) {}
	///<summary>Remove all actors from the selection set</summary>
	public  void ClearActorSelectionSet() {}
	///<summary>Selects nothing in the editor (another way to clear the selection)</summary>
	public  void SelectNothing() {}
	///<summary>Set the selection state for the selected actor</summary>
	public  void SetActorSelectionState(AActor Actor,bool bShouldBeSelected) {}
	///<summary>Attempts to find the actor specified by PathToActor in the current editor world</summary>
	public  AActor GetActorReference(string PathToActor) { return default; }
}
