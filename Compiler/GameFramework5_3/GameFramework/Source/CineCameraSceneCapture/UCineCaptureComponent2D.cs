namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cine Capture Component extends Scene Capture to allow users to render Cine Camera Component into a render target.</summary>
[CppInclude("CineCameraSceneCaptureComponent.h")]
public partial class UCineCaptureComponent2D : USceneCaptureComponent2D {
	public static UClass StaticClass() {return default;}
	///<summary>Highest possible dimension of specified render target in either X or Y (depends on cine camera aspect ratio). Used to adjust the render target size.</summary>
	public int RenderTargetHighestDimension;
	///<summary>Affects rendering path cine capture takes. Scene Capture takes a slightly different rendering route compared to viewport rendering</summary>
	public bool bFollowSceneCaptureRenderPath;
	///<summary>Open Color IO Configuration. Used to apply color transforms.</summary>
	public FOpenColorIODisplayConfiguration OCIOConfiguration;
	///<summary>Used to gather relevant properties for View rendering.</summary>
	public TSoftObjectPtr<UCineCameraComponent> CineCameraComponent;
}
