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
	public FName AlphaCurveName;
	public FInputScaleBiasClamp AlphaScaleBiasClamp;
	public TMap<FName,FName> InputMapping;
	public TMap<FName,FName> OutputMapping;
	public int LODThreshold;
}
