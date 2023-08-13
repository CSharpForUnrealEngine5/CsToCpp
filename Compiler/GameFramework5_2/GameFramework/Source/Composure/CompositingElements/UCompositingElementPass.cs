namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UCompositingElementPass</summary>
[CppInclude("CompositingElements/CompositingElementPasses.h")]
public partial class UCompositingElementPass : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>bEnabled</summary>
	public bool bEnabled;
	///<summary>PassName</summary>
	public string PassName;
	///<summary>OnFrameBegin</summary>
	public void OnFrameBegin(bool bCameraCutThisFrame) {}
	///<summary>OnFrameEnd</summary>
	public void OnFrameEnd() {}
	///<summary>Reset</summary>
	public void Reset() {}
	///<summary>IsPassEnabled</summary>
	public bool IsPassEnabled() { return default; }
	///<summary>SetPassEnabled</summary>
	public void SetPassEnabled(bool bSetEnabledTo/*=true*/) {}
	///<summary>OnDisabled</summary>
	public void OnDisabled() {}
	///<summary>OnEnabled</summary>
	public void OnEnabled() {}
	///<summary>, meta = (BlueprintProtected = &quot;true&quot;)</summary>
	public UTextureRenderTarget2D RequestRenderTarget(FIntPoint Dimensions,ETextureRenderTargetFormat Format) { return default; }
	///<summary>, meta = (BlueprintProtected = &quot;true&quot;)</summary>
	public UTextureRenderTarget2D RequestNativelyFormattedTarget(float RenderScale/*=1.0f*/) { return default; }
	///<summary>, meta = (BlueprintProtected = &quot;true&quot;)</summary>
	public bool ReleaseRenderTarget(UTextureRenderTarget2D AssignedTarget) { return default; }
}
