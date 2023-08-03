#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraActor.h")]
public partial class AVirtualCameraActor : ACineCameraActor {
	public static UClass StaticClass() {return default;}
	///<summary>SceneCaptureComponent</summary>
	public USceneCaptureComponent2D SceneCaptureComponent;
	///<summary>LiveLinkSubject</summary>
	public FLiveLinkSubjectRepresentation LiveLinkSubject;
	///<summary>MovementComponent</summary>
	public UVirtualCameraMovement MovementComponent;
	///<summary>MediaOutput</summary>
	public URemoteSessionMediaOutput MediaOutput;
	///<summary>CameraUMGClass</summary>
	public UClass CameraUMGClass;
	///<summary>TargetDeviceResolution</summary>
	public FVector2D TargetDeviceResolution;
	///<summary>RemoteSessionPort</summary>
	public int RemoteSessionPort;
	///<summary>CameraScreenWidget</summary>
	public UVPFullScreenUserWidget CameraScreenWidget;
	///<summary>MediaCapture</summary>
	public URemoteSessionMediaCapture MediaCapture;
	///<summary>ActorWorld</summary>
	public UWorld ActorWorld;
	///<summary>PreviousViewTarget</summary>
	public AActor PreviousViewTarget;
	///<summary>Should focus plane be shown on all touch focus events</summary>
	public bool bAllowFocusVisualization;
	///<summary>Delegate that will is triggered before transform is set onto Actor.</summary>
	public FPreSetVirtualCameraTransform OnPreSetVirtualCameraTransform;
	///<summary>Delegate that will be triggered when an actor has been clicked/touched.</summary>
	public FOnActorClickedDelegate OnActorClickedDelegate;
	///<summary>This delegate is triggered at the end of a tick in editor/pie/game.</summary>
	public FVirtualCameraTickDelegateGroup OnVirtualCameraUpdatedDelegates;
	///<summary>Stores the list of settings presets, and saved presets</summary>
	public TMap<string,FVirtualCameraSettingsPreset> SettingsPresets;
	///<summary>StreamedCamera</summary>
	public UCineCameraComponent StreamedCamera;
}
