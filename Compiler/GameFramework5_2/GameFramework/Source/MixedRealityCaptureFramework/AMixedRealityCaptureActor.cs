#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MixedRealityCaptureActor.h")]
public partial class AMixedRealityCaptureActor : AActor {
// MixedRealityCaptureActor
	public UMixedRealityCaptureComponent CaptureComponent;
	public bool bAutoAttachToVRPlayer;
	public bool bAutoHidePlayer;
	public bool bHideAttachmentsWithPlayer;
	public bool bAutoBroadcast;
	public  void SetAutoBroadcast(bool bNewValue) {}
	public  bool IsBroadcasting() { return default; }
	public  UTexture GetCaptureTexture() { return default; }
	public  void OnTargetDestroyed(AActor DestroyedActor) {}
	public UStaticMesh DebugVisualizerMesh;
}
