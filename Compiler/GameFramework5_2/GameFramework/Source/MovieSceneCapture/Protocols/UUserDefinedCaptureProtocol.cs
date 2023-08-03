#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A blueprintable capture protocol that defines how to capture frames from the engine</summary>
[CppInclude("Protocols/UserDefinedCaptureProtocol.h")]
public partial class UUserDefinedCaptureProtocol : UMovieSceneImageCaptureProtocolBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called before the capture process itself is ticked, before each frame is set up for capture</summary>
	public  void OnPreTick() {}
	///<summary>Called after the capture process itself is ticked, after the frame is set up for capture, but before most actors have ticked</summary>
	public  void OnTick() {}
	///<summary>Called once at the start of the capture process, but before any warmup frames</summary>
	public  bool OnSetup() { return default; }
	///<summary>Called when the capture process is warming up. Protocols may transition from either an initialized, or capturing state to warm-up</summary>
	public  void OnWarmUp() {}
	///<summary>Called when this protocol should start capturing frames</summary>
	public  void OnStartCapture() {}
	///<summary>Called when this protocol should capture the current frame</summary>
	public  void OnCaptureFrame() {}
	///<summary>Called when this protocol should temporarily stop capturing frames</summary>
	public  void OnPauseCapture() {}
	///<summary>Called when this protocol is going to be shut down - should not capture any more frames</summary>
	public  void OnBeginFinalize() {}
	///<summary>Called to check whether this protocol has finished any pending tasks, and can now be shut down</summary>
	public  bool OnCanFinalize() { return default; }
	///<summary>Called to complete finalization of this protocol</summary>
	public  void OnFinalize() {}
	///<summary>Called when pixels have been received for the specified stream name</summary>
	public  void OnPixelsReceived(FCapturedPixels Pixels,FCapturedPixelsID ID,FFrameMetrics FrameMetrics) {}
	///<summary>* Resolve the specified buffer and pass it directly to the specified handler when done (does not pass to any bound streams)</summary>
	public  void ResolveBuffer(UTexture Buffer,FCapturedPixelsID BufferID) {}
	///<summary>Instruct this protocol to start capturing LDR final pixels (including slate widgets and burn-ins)</summary>
	public  void StartCapturingFinalPixels(FCapturedPixelsID StreamID) {}
	///<summary>Instruct this protocol to stop capturing LDR final pixels</summary>
	public  void StopCapturingFinalPixels() {}
	///<summary>Generate a filename for the current frame</summary>
	public  string GenerateFilename(FFrameMetrics InFrameMetrics) { return default; }
	///<summary>Access this protocol&#39;s current frame metrics</summary>
	public  FFrameMetrics GetCurrentFrameMetrics() { return default; }
	///<summary>World pointer assigned on Setup</summary>
	public UWorld World;
}
