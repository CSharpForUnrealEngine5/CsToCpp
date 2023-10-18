namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineWidgetRenderSetting.h")]
public partial class UMoviePipelineWidgetRenderer : UMoviePipelineRenderPass {
	public static UClass StaticClass() {return default;}
	///<summary>If true, the widget renderer image will be composited into the Final Image pass. Doesn&#39;t apply to multi-layer EXR files.</summary>
	public bool bCompositeOntoFinalImage;
	///<summary>RenderTarget</summary>
	public UTextureRenderTarget2D RenderTarget;
}
