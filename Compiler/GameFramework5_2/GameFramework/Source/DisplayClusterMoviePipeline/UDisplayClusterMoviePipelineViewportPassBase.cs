namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>nDisplay viewport render pass (Lit)</summary>
[CppInclude("DisplayClusterMoviePipelineViewportPass.h")]
public partial class UDisplayClusterMoviePipelineViewportPassBase : UMoviePipelineDeferredPassBase {
	public static UClass StaticClass() {return default;}
	///<summary>Allow warp blend for this pass</summary>
	public bool bEnabledWarpBlend;
}
