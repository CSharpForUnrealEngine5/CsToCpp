#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>nDisplay viewport render pass (PathTracer)</summary>
[CppInclude("DisplayClusterMoviePipelineViewportPass.h")]
public partial class UDisplayClusterMoviePipelineViewportPass_PathTracer : UDisplayClusterMoviePipelineViewportPassBase {
	///<summary>When enabled, the path tracer will blend all spatial and temporal samples prior to the denoising and will disable post-processed motion blur.</summary>
	public bool bReferenceMotionBlur;
}
