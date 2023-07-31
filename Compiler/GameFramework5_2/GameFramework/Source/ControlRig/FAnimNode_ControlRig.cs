#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Animation node that allows animation ControlRig output to be used in an animation graph</summary>
[CppInclude("AnimNode_ControlRig.h")]
public partial struct FAnimNode_ControlRig {
	public UClass ControlRigClass;
	public UControlRig ControlRig;
	public float Alpha;
	public EAnimAlphaInputType AlphaInputType;
	public bool bAlphaBoolEnabled;
	public bool bSetRefPoseFromSkeleton;
	public FInputScaleBias AlphaScaleBias;
	public FInputAlphaBoolBlend AlphaBoolBlend;
	public string AlphaCurveName;
	public FInputScaleBiasClamp AlphaScaleBiasClamp;
	public TMap<string,string> InputMapping;
	public TMap<string,string> OutputMapping;
	public int LODThreshold;
}
