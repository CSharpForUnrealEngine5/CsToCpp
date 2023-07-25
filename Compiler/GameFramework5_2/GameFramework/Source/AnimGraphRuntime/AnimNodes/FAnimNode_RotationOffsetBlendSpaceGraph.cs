#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_RotationOffsetBlendSpaceGraph.h")]
///<summary>Allows multiple animations to be blended between based on input parameters</summary>
public partial struct FAnimNode_RotationOffsetBlendSpaceGraph {
// AnimNode_RotationOffsetBlendSpaceGraph
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
