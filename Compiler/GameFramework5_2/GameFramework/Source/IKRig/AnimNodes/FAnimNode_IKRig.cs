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
	public FName AlphaCurveName;
	public FInputScaleBiasClamp AlphaScaleBiasClamp;
	public UIKRigProcessor IKRigProcessor;
	public float ActualAlpha;
}
