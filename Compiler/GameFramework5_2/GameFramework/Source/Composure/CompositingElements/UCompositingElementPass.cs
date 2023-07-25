#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementPasses.h")]
///<summary>UCompositingElementPass</summary>
public partial class UCompositingElementPass : UObject {
// CompositingElementPass
	public bool bEnabled;
	public string PassName;
	public void OnFrameBegin(bool bCameraCutThisFrame) {}
	public void OnFrameEnd() {}
	public void Reset() {}
	public bool IsPassEnabled() { return default; }
	public void SetPassEnabled(bool bSetEnabledTo/*=true*/) {}
	public void OnDisabled() {}
	public void OnEnabled() {}
	public UObject RequestRenderTarget(FIntPoint Dimensions,ETextureRenderTargetFormat Format) { return default; }
	public UObject RequestNativelyFormattedTarget(float RenderScale/*=1.0f*/) { return default; }
	public bool ReleaseRenderTarget(UObject AssignedTarget) { return default; }
}
