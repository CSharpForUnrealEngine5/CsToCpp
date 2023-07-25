#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IVirtualCameraController.h")]
public partial class UVirtualCameraController : UInterface {
// VirtualCameraController
	public UObject GetStreamedCameraComponent() { return default; }
	public UObject GetSceneCaptureComponent() { return default; }
	public UObject GetSequenceController() { return default; }
	public object /*ReturnValue*/ GetPresetContainer() { return default; }
	public object /*ReturnValue*/ GetOptions() { return default; }
	public FLiveLinkSubjectRepresentation GetLiveLinkRepresentation() { return default; }
	public void SetLiveLinkRepresentation(FLiveLinkSubjectRepresentation InLiveLinkRepresenation) {}
	public bool IsStreaming() { return default; }
	public bool ShouldSaveSettingsOnStopStreaming() { return default; }
	public void SetSaveSettingsOnStopStreaming(bool bShouldSettingsSave) {}
	public FTransform GetRelativeTransform() { return default; }
	public void AddBlendableToCamera(object /*InBlendableToAdd*/ InBlendableToAdd,float InWeight) {}
	public void SetTrackedActorForFocus(UObject InActorToTrack,FVector TrackingPointOffset) {}
	public void SetFocusVisualization(bool bInShowFocusVisualization) {}
	public void SetBeforeSetVirtualCameraTransformDelegate(FPreSetVirtualCameraTransform InDelegate) {}
	public void SetOnActorClickedDelegate(FOnActorClickedDelegate InDelegate) {}
	public void AddOnVirtualCameraUpdatedDelegate(FVirtualCameraTickDelegate InDelegate) {}
	public void RemoveOnVirtualCameraUpdatedDelegate(FVirtualCameraTickDelegate InDelegate) {}
}
