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
	public FName AlphaCurveName;
	public FInputScaleBiasClamp AlphaScaleBiasClamp;
	public EAnimAlphaInputType AlphaInputType;
	public bool bAlphaBoolEnabled;
}
