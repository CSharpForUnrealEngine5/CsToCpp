#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PlacedEditorUtilityBase.h")]
public partial class ADEPRECATED_PlacedEditorUtilityBase : AActor {
// PlacedEditorUtilityBase
	public string HelpText;
	public TArray<UObject> GetSelectionSet() { return default; }
	public bool GetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) { return default; }
	public void SetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) {}
	public void ClearActorSelectionSet() {}
	public void SelectNothing() {}
	public void SetActorSelectionState(UObject Actor,bool bShouldBeSelected) {}
	public UObject GetActorReference(string PathToActor) { return default; }
}
