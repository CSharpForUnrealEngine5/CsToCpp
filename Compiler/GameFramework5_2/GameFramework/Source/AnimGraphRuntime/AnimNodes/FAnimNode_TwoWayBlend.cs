#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_TwoWayBlend.h")]
///<summary>This represents a baked transition</summary>
public partial struct FAnimNode_TwoWayBlend {
// AnimNode_TwoWayBlend
	public FPoseLink A;
	public FPoseLink B;
	public EAnimAlphaInputType AlphaInputType;
	public bool bAlphaBoolEnabled;
	public bool bResetChildOnActivation;
	public float Alpha;
	public FInputScaleBias AlphaScaleBias;
	public FInputAlphaBoolBlend AlphaBoolBlend;
	public string AlphaCurveName;
	public FInputScaleBiasClamp AlphaScaleBiasClamp;
}
