#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_RotationOffsetBlendSpace.h")]
///<summary>@TODO: Comment</summary>
public partial struct FAnimNode_RotationOffsetBlendSpace {
// AnimNode_RotationOffsetBlendSpace
	public FPoseLink BasePose;
	public int LODThreshold;
	public float Alpha;
	public FInputScaleBias AlphaScaleBias;
	public FInputAlphaBoolBlend AlphaBoolBlend;
	public string AlphaCurveName;
	public FInputScaleBiasClamp AlphaScaleBiasClamp;
	public EAnimAlphaInputType AlphaInputType;
	public bool bAlphaBoolEnabled;
}
