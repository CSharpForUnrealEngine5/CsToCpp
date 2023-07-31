#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract base class for media capture.</summary>
[CppInclude("MediaCapture.h")]
public partial class UMediaCapture : UObject {
	///<summary>Stop the current capture if there is one.</summary>
	public  bool CaptureActiveSceneViewport(FMediaCaptureOptions CaptureOptions) { return default; }
	///<summary>Stop the actual capture if there is one.</summary>
	public  bool CaptureTextureRenderTarget2D(UTextureRenderTarget2D RenderTarget,FMediaCaptureOptions CaptureOptions) { return default; }
	///<summary>Update the current capture with every frame for a TextureRenderTarget2D.</summary>
	public  bool UpdateTextureRenderTarget2D(UTextureRenderTarget2D RenderTarget) { return default; }
	///<summary>Stop the previous requested capture.</summary>
	public  void StopCapture(bool bAllowPendingFrameToBeProcess) {}
	///<summary>Get the current state of the capture.</summary>
	public  EMediaCaptureState GetState() { return default; }
	///<summary>Set the media output. Can only be set when the capture is stopped.</summary>
	public  void SetMediaOutput(UMediaOutput InMediaOutput) {}
	///<summary>Get the desired size of the current capture.</summary>
	public  FIntPoint GetDesiredSize() { return default; }
	///<summary>Get the desired pixel format of the current capture.</summary>
	public  EPixelFormat GetDesiredPixelFormat() { return default; }
	///<summary>Called when the state of the capture changed.</summary>
	public FMediaCaptureStateChangedSignature OnStateChanged;
	///<summary>MediaOutput associated with this capture</summary>
	public UMediaOutput MediaOutput;
}
