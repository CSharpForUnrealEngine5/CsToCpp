#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineAntiAliasingSetting.h")]
public partial class UMoviePipelineAntiAliasingSetting : UMoviePipelineSetting {
	///<summary>How many frames should we accumulate together before contributing to one overall sample. This lets you</summary>
	public int SpatialSampleCount;
	///<summary>The number of frames we should combine together to produce each output frame. This blends the</summary>
	public int TemporalSampleCount;
	///<summary>Should we override the Project&#39;s anti-aliasing setting during a movie render? This can be useful to have</summary>
	public bool bOverrideAntiAliasing;
	///<summary>If we are overriding the AA method, what do we use? None will turn off anti-aliasing.</summary>
	public EAntiAliasingMethod AntiAliasingMethod;
	///<summary>The number of frames at the start of each shot that the engine will render and then discard. This is useful for</summary>
	public int RenderWarmUpCount;
	///<summary>Should we use the excess in the camera cut track to determine engine warmup? When disabled, the sequence is evaluated</summary>
	public bool bUseCameraCutForWarmUp;
	///<summary>The number of frames at the start of each shot that the engine will run without rendering. This allows pre-warming</summary>
	public int EngineWarmUpCount;
	///<summary>Should we submit the warm-up frames to the GPU? Generally you want this disabled (as it is more performant), but</summary>
	public bool bRenderWarmUpFrames;
}
