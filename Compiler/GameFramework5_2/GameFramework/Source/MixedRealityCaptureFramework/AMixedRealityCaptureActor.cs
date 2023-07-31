#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MixedRealityCaptureActor.h")]
public partial class AMixedRealityCaptureActor : AActor {
	///<summary>CaptureComponent</summary>
	public UMixedRealityCaptureComponent CaptureComponent;
	///<summary>bAutoAttachToVRPlayer</summary>
	public bool bAutoAttachToVRPlayer;
	///<summary>bAutoHidePlayer</summary>
	public bool bAutoHidePlayer;
	///<summary>bHideAttachmentsWithPlayer</summary>
	public bool bHideAttachmentsWithPlayer;
	///<summary>If true the capture texture will automatically be applied to the Spectator Screen.</summary>
	public bool bAutoBroadcast;
	///<summary>SetAutoBroadcast</summary>
	public  void SetAutoBroadcast(bool bNewValue) {}
	///<summary>IsBroadcasting</summary>
	public  bool IsBroadcasting() { return default; }
	///<summary>GetCaptureTexture</summary>
	public  UTexture GetCaptureTexture() { return default; }
	///<summary>OnTargetDestroyed</summary>
	public  void OnTargetDestroyed(AActor DestroyedActor) {}
	///<summary>DebugVisualizerMesh</summary>
	public UStaticMesh DebugVisualizerMesh;
}
