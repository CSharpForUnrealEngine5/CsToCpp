#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_ApplyAdditive.h")]
public partial struct FAnimNode_ApplyAdditive {
	public FPoseLink Base;
	public FPoseLink Additive;
	public float Alpha;
	public FInputScaleBias AlphaScaleBias;
	public int LODThreshold;
	public FInputAlphaBoolBlend AlphaBoolBlend;
	public string AlphaCurveName;
	public FInputScaleBiasClamp AlphaScaleBiasClamp;
	public EAnimAlphaInputType AlphaInputType;
	public bool bAlphaBoolEnabled;
}
