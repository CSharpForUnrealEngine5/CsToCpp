#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaCapture.h")]
///<summary>Abstract base class for media capture.</summary>
public partial class UMediaCapture : UObject {
// MediaCapture
	public bool CaptureActiveSceneViewport(FMediaCaptureOptions CaptureOptions) { return default; }
	public bool CaptureTextureRenderTarget2D(UObject RenderTarget,FMediaCaptureOptions CaptureOptions) { return default; }
	public bool UpdateTextureRenderTarget2D(UObject RenderTarget) { return default; }
	public void StopCapture(bool bAllowPendingFrameToBeProcess) {}
	public EMediaCaptureState GetState() { return default; }
	public void SetMediaOutput(UObject InMediaOutput) {}
	public FIntPoint GetDesiredSize() { return default; }
	public EPixelFormat GetDesiredPixelFormat() { return default; }
	public FMediaCaptureStateChangedSignature OnStateChanged;
	public UMediaOutput MediaOutput;
}
