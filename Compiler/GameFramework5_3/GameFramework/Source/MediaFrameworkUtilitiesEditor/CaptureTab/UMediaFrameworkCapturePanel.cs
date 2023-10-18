namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CaptureTab/MediaFrameworkCapturePanelBlueprintLibrary.h")]
public partial class UMediaFrameworkCapturePanel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Capture the camera&#39;s viewport and the render target.</summary>
	public void StartCapture() {}
	///<summary>Stop the current capture.</summary>
	public void StopCapture() {}
	///<summary>Clear all the render target captures.</summary>
	public void EmptyRenderTargetCapture() {}
	///<summary>Add a render target 2d to be captured.</summary>
	public void AddRenderTargetCapture(UMediaOutput MediaOutput,UTextureRenderTarget2D RenderTarget,FMediaCaptureOptions CaptureOptions) {}
	///<summary>Clear all the viewport captures.</summary>
	public void EmptyViewportCapture() {}
	///<summary>Add a camera to be used when capturing the current viewport.</summary>
	public void AddViewportCapture(UMediaOutput MediaOutput,AActor Camera,FMediaCaptureOptions CaptureOptions,EViewModeIndex ViewMode/*=VMI_Unknown*/) {}
	///<summary>Change the setting for capturing the current viewport.</summary>
	public void SetCurrentViewportCapture(UMediaOutput MediaOutput,FMediaCaptureOptions CaptureOptions,EViewModeIndex ViewMode/*=VMI_Unknown*/) {}
}
