namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@TODO: Comment</summary>
[CppInclude("AnimNodes/AnimNode_RotationOffsetBlendSpace.h")]
public partial struct FAnimNode_RotationOffsetBlendSpace {
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
