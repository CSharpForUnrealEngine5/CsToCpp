#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_IKRig.h")]
public partial struct FAnimNode_IKRig {
	public FPoseLink Source;
	public UIKRigDefinition RigDefinitionAsset;
	public TArray<FIKRigGoal> Goals;
	public bool bStartFromRefPose;
	public bool bEnableDebugDraw;
	public float DebugScale;
	public EAnimAlphaInputType AlphaInputType;
	public bool bAlphaBoolEnabled;
	public float Alpha;
	public FInputScaleBias AlphaScaleBias;
	public FInputAlphaBoolBlend AlphaBoolBlend;
	public string AlphaCurveName;
	public FInputScaleBiasClamp AlphaScaleBiasClamp;
	public UIKRigProcessor IKRigProcessor;
	public float ActualAlpha;
}
