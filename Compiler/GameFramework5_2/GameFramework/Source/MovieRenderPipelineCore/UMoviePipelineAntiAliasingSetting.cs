#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineAntiAliasingSetting.h")]
public partial class UMoviePipelineAntiAliasingSetting : UMoviePipelineSetting {
// MoviePipelineAntiAliasingSetting
	public int SpatialSampleCount;
	public int TemporalSampleCount;
	public bool bOverrideAntiAliasing;
	public byte AntiAliasingMethod;
	public int RenderWarmUpCount;
	public bool bUseCameraCutForWarmUp;
	public int EngineWarmUpCount;
	public bool bRenderWarmUpFrames;
}
