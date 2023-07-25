#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNode_ControlRig.h")]
///<summary>Animation node that allows animation ControlRig output to be used in an animation graph</summary>
public partial struct FAnimNode_ControlRig {
// AnimNode_ControlRig
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
