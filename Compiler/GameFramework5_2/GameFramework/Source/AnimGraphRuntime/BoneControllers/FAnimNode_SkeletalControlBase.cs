#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_SkeletalControlBase.h")]
public partial struct FAnimNode_SkeletalControlBase {
// AnimNode_SkeletalControlBase
	public FComponentSpacePoseLink ComponentPose;
	public int LODThreshold;
	public float ActualAlpha;
	public EAnimAlphaInputType AlphaInputType;
	public bool bAlphaBoolEnabled;
	public float Alpha;
	public FInputScaleBias AlphaScaleBias;
	public FInputAlphaBoolBlend AlphaBoolBlend;
	public string AlphaCurveName;
	public FInputScaleBiasClamp AlphaScaleBiasClamp;
	public string ValidationVisualWarningMessage;
}
