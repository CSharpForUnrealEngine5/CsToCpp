#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineBurnInSetting.h")]
public partial class UMoviePipelineBurnInSetting : UMoviePipelineRenderPass {
// MoviePipelineBurnInSetting
	public FSoftClassPath BurnInClass;
	public bool bCompositeOntoFinalImage;
	public UTextureRenderTarget2D RenderTarget;
	public TArray<UMoviePipelineBurnInWidget> BurnInWidgetInstances;
}
