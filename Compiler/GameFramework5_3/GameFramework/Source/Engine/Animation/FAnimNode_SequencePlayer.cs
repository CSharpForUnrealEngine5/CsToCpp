namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sequence player node that can be used with constant folding</summary>
[CppInclude("Animation/AnimNode_SequencePlayer.h")]
public partial struct FAnimNode_SequencePlayer {
	public FName GroupName;
	public EAnimGroupRole GroupRole;
	public EAnimSyncMethod Method;
	public bool bIgnoreForRelevancyTest;
	public UAnimSequenceBase Sequence;
	public float PlayRateBasis;
	public float PlayRate;
	public FInputScaleBiasClampConstants PlayRateScaleBiasClampConstants;
	public FInputScaleBiasClamp PlayRateScaleBiasClamp_DEPRECATED;
	public float StartPosition;
	public bool bLoopAnimation;
	public bool bStartFromMatchingPose;
}
