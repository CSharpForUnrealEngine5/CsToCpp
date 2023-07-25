#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CaptureTab/MediaFrameworkCapturePanelBlueprintLibrary.h")]
public partial class UMediaFrameworkCapturePanel : UObject {
// MediaFrameworkCapturePanel
	public void StartCapture() {}
	public void StopCapture() {}
	public void EmptyRenderTargetCapture() {}
	public void AddRenderTargetCapture(UObject MediaOutput,UObject RenderTarget,FMediaCaptureOptions CaptureOptions) {}
	public void EmptyViewportCapture() {}
	public void AddViewportCapture(UObject MediaOutput,UObject Camera,FMediaCaptureOptions CaptureOptions,EViewModeIndex ViewMode/*=VMI_Unknown*/) {}
	public void SetCurrentViewportCapture(UObject MediaOutput,FMediaCaptureOptions CaptureOptions,EViewModeIndex ViewMode/*=VMI_Unknown*/) {}
}
