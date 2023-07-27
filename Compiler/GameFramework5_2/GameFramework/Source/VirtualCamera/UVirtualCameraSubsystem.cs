#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraSubsystem.h")]
public partial class UVirtualCameraSubsystem : UEngineSubsystem {
// VirtualCameraSubsystem
	public  bool StartStreaming() { return default; }
	public  bool StopStreaming() { return default; }
	public  bool IsStreaming() { return default; }
	public  void HandleSelectionChangedEvent(UObject SelectedObject) {}
	public  void HandleSelectObjectEvent(UObject SelectedObject) {}
	public  object /*ReturnValue*/ GetVirtualCameraController() { return default; }
	public  void SetVirtualCameraController(object /*VirtualCamera*/ VirtualCamera) {}
	public ULevelSequencePlaybackController SequencePlaybackController;
	public FOnStreamStarted OnStreamStartedDelegate;
	public FOnStreamStopped OnStreamStoppedDelegate;
	public FOnSelectedAnyActor OnSelectedAnyActorDelegate;
	public FOnSelectedViewportActor OnSelectedActorInViewportDelegate;
	public object /*ActiveCameraController*/ ActiveCameraController;
}
