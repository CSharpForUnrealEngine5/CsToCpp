namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluates a point in an anim sequence, using a specific time input rather than advancing time internally.</summary>
[CppInclude("AnimNodes/AnimNode_PoseBlendNode.h")]
public partial struct FAnimNode_PoseBlendNode {
	public FPoseLink SourcePose;
	public EAlphaBlendOption BlendOption;
	public UCurveFloat CustomCurve;
}
