#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IVirtualCameraController.h")]
public partial class UVirtualCameraController : UInterface {
	///<summary>Returns the target camera that is used to create the streamed view.</summary>
	public  UCineCameraComponent GetStreamedCameraComponent() { return default; }
	///<summary>GetSceneCaptureComponent</summary>
	public  USceneCaptureComponent2D GetSceneCaptureComponent() { return default; }
	///<summary>Returns the VirtualCamera&#39;s Sequence Controller.</summary>
	public  ULevelSequencePlaybackController GetSequenceController() { return default; }
	///<summary>GetPresetContainer</summary>
	public  object /*ReturnValue*/ GetPresetContainer() { return default; }
	///<summary>GetOptions</summary>
	public  object /*ReturnValue*/ GetOptions() { return default; }
	///<summary>GetLiveLinkRepresentation</summary>
	public  FLiveLinkSubjectRepresentation GetLiveLinkRepresentation() { return default; }
	///<summary>SetLiveLinkRepresentation</summary>
	public  void SetLiveLinkRepresentation(FLiveLinkSubjectRepresentation InLiveLinkRepresenation) {}
	///<summary>IsStreaming</summary>
	public  bool IsStreaming() { return default; }
	///<summary>Check whether settings should save when stream is stopped.</summary>
	public  bool ShouldSaveSettingsOnStopStreaming() { return default; }
	///<summary>Sets whether settings should be saved when stream is stopped.</summary>
	public  void SetSaveSettingsOnStopStreaming(bool bShouldSettingsSave) {}
	///<summary>GetRelativeTransform</summary>
	public  FTransform GetRelativeTransform() { return default; }
	///<summary>AddBlendableToCamera</summary>
	public  void AddBlendableToCamera(object /*InBlendableToAdd*/ InBlendableToAdd,float InWeight) {}
	///<summary>SetTrackedActorForFocus</summary>
	public  void SetTrackedActorForFocus(AActor InActorToTrack,FVector TrackingPointOffset) {}
	///<summary>SetFocusVisualization</summary>
	public  void SetFocusVisualization(bool bInShowFocusVisualization) {}
	///<summary>Delegate will be executed before transform is set onto VirtualCamera.</summary>
	public  void SetBeforeSetVirtualCameraTransformDelegate(FPreSetVirtualCameraTransform InDelegate) {}
	///<summary>Delegate will be executed when an actor in the scene was clicked/touched.</summary>
	public  void SetOnActorClickedDelegate(FOnActorClickedDelegate InDelegate) {}
	///<summary>Adds a delegate that will be executed every tick while streaming.</summary>
	public  void AddOnVirtualCameraUpdatedDelegate(FVirtualCameraTickDelegate InDelegate) {}
	///<summary>Remove delegate that is executed every tick while streaming.</summary>
	public  void RemoveOnVirtualCameraUpdatedDelegate(FVirtualCameraTickDelegate InDelegate) {}
}
