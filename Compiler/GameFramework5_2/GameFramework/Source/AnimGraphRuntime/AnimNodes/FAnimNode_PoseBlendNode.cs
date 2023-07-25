#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_PoseBlendNode.h")]
///<summary>Evaluates a point in an anim sequence, using a specific time input rather than advancing time internally.</summary>
public partial struct FAnimNode_PoseBlendNode {
// AnimNode_PoseBlendNode
	public FPoseLink SourcePose;
	public EAlphaBlendOption BlendOption;
	public UCurveFloat CustomCurve;
}
