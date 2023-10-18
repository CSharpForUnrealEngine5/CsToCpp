namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PoseWatch.h")]
public partial class UPoseWatchPoseElement : UPoseWatchElement {
	public static UClass StaticClass() {return default;}
	///<summary>Optionally select a Blend Mask to control which bones on the skeleton are rendered. Any non-zero entries are rendered.</summary>
	public UBlendProfile ViewportMask;
	///<summary>Invert which bones are rendered when using a viewport mask</summary>
	public bool bInvertViewportMask;
	///<summary>The threshold which each bone&#39;s blend scale much surpass to be rendered using the viewport mask</summary>
	public float BlendScaleThreshold;
	///<summary>Offset the rendering of the bones in the viewport.</summary>
	public FVector3d ViewportOffset;
}
