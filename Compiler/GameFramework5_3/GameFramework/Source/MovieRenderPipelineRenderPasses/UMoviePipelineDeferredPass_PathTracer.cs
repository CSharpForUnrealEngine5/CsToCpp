namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineDeferredPasses.h")]
public partial class UMoviePipelineDeferredPass_PathTracer : UMoviePipelineDeferredPassBase {
	public static UClass StaticClass() {return default;}
	///<summary>When enabled, the path tracer will blend all spatial and temporal samples prior to the denoising and will disable post-processed motion blur.</summary>
	public bool bReferenceMotionBlur;
}
