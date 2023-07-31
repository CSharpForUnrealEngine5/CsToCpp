#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This represents a baked transition</summary>
[CppInclude("AnimNodes/AnimNode_TwoWayBlend.h")]
public partial struct FAnimNode_TwoWayBlend {
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
