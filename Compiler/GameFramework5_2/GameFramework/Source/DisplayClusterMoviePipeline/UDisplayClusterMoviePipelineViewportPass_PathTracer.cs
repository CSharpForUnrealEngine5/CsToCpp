namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>nDisplay viewport render pass (PathTracer)</summary>
[CppInclude("DisplayClusterMoviePipelineViewportPass.h")]
public partial class UDisplayClusterMoviePipelineViewportPass_PathTracer : UDisplayClusterMoviePipelineViewportPassBase {
	public static UClass StaticClass() {return default;}
	///<summary>When enabled, the path tracer will blend all spatial and temporal samples prior to the denoising and will disable post-processed motion blur.</summary>
	public bool bReferenceMotionBlur;
}
