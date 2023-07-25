#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraActor.h")]
public partial class AVirtualCameraActor : ACineCameraActor {
// VirtualCameraActor
	public USceneCaptureComponent2D SceneCaptureComponent;
	public FLiveLinkSubjectRepresentation LiveLinkSubject;
	public UVirtualCameraMovement MovementComponent;
	public URemoteSessionMediaOutput MediaOutput;
	public UClass CameraUMGClass;
	public FVector2D TargetDeviceResolution;
	public int RemoteSessionPort;
	public UVPFullScreenUserWidget CameraScreenWidget;
	public URemoteSessionMediaCapture MediaCapture;
	public UWorld ActorWorld;
	public AActor PreviousViewTarget;
	public bool bAllowFocusVisualization;
	public FPreSetVirtualCameraTransform OnPreSetVirtualCameraTransform;
	public FOnActorClickedDelegate OnActorClickedDelegate;
	public FVirtualCameraTickDelegateGroup OnVirtualCameraUpdatedDelegates;
	public TMap<string,FVirtualCameraSettingsPreset> SettingsPresets;
	public UCineCameraComponent StreamedCamera;
}
