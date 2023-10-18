namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows multiple animations to be blended between based on input parameters</summary>
[CppInclude("AnimNodes/AnimNode_RotationOffsetBlendSpaceGraph.h")]
public partial struct FAnimNode_RotationOffsetBlendSpaceGraph {
	public FPoseLink BasePose;
	public int LODThreshold;
	public float Alpha;
	public FInputScaleBias AlphaScaleBias;
	public FInputAlphaBoolBlend AlphaBoolBlend;
	public FName AlphaCurveName;
	public FInputScaleBiasClamp AlphaScaleBiasClamp;
	public EAnimAlphaInputType AlphaInputType;
	public bool bAlphaBoolEnabled;
}
