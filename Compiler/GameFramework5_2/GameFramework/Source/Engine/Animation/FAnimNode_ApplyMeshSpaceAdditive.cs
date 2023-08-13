namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_ApplyMeshSpaceAdditive.h")]
public partial struct FAnimNode_ApplyMeshSpaceAdditive {
	public FPoseLink Base;
	public FPoseLink Additive;
	public EAnimAlphaInputType AlphaInputType;
	public float Alpha;
	public bool bAlphaBoolEnabled;
	public FInputAlphaBoolBlend AlphaBoolBlend;
	public string AlphaCurveName;
	public FInputScaleBias AlphaScaleBias;
	public FInputScaleBiasClamp AlphaScaleBiasClamp;
	public int LODThreshold;
}
