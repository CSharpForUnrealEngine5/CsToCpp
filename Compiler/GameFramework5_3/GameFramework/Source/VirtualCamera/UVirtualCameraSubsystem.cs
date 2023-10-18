namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraSubsystem.h")]
public partial class UVirtualCameraSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>StartStreaming</summary>
	public bool StartStreaming() { return default; }
	///<summary>StopStreaming</summary>
	public bool StopStreaming() { return default; }
	///<summary>IsStreaming</summary>
	public bool IsStreaming() { return default; }
	///<summary>HandleSelectionChangedEvent</summary>
	public void HandleSelectionChangedEvent(UObject SelectedObject) {}
	///<summary>HandleSelectObjectEvent</summary>
	public void HandleSelectObjectEvent(UObject SelectedObject) {}
	///<summary>GetVirtualCameraController</summary>
	public object /*ReturnValue*/ GetVirtualCameraController() { return default; }
	///<summary>SetVirtualCameraController</summary>
	public void SetVirtualCameraController(object /*VirtualCamera*/ VirtualCamera) {}
	///<summary>SequencePlaybackController</summary>
	public ULevelSequencePlaybackController SequencePlaybackController;
	///<summary>OnStreamStartedDelegate</summary>
	public FOnStreamStarted OnStreamStartedDelegate;
	///<summary>OnStreamStoppedDelegate</summary>
	public FOnStreamStopped OnStreamStoppedDelegate;
	///<summary>OnSelectedAnyActorDelegate</summary>
	public FOnSelectedAnyActor OnSelectedAnyActorDelegate;
	///<summary>OnSelectedActorInViewportDelegate</summary>
	public FOnSelectedViewportActor OnSelectedActorInViewportDelegate;
	///<summary>ActiveCameraController</summary>
	public object /*ActiveCameraController*/ ActiveCameraController;
}
