#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineBurnInSetting.h")]
public partial class UMoviePipelineBurnInSetting : UMoviePipelineRenderPass {
	public static UClass StaticClass() {return default;}
	///<summary>BurnInClass</summary>
	public FSoftClassPath BurnInClass;
	///<summary>If true, the Burn In image will be composited into the Final Image pass. Doesn&#39;t apply to multi-layer EXR files.</summary>
	public bool bCompositeOntoFinalImage;
	///<summary>RenderTarget</summary>
	public UTextureRenderTarget2D RenderTarget;
	///<summary>BurnInWidgetInstances</summary>
	public TArray<UMoviePipelineBurnInWidget> BurnInWidgetInstances;
}
