namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sequence player node that can be used standalone (without constant folding)</summary>
[CppInclude("Animation/AnimNode_SequencePlayer.h")]
public partial struct FAnimNode_SequencePlayer_Standalone {
	public string GroupName;
	public EAnimGroupRole GroupRole;
	public EAnimSyncMethod Method;
	public bool bIgnoreForRelevancyTest;
	public UAnimSequenceBase Sequence;
	public float PlayRateBasis;
	public float PlayRate;
	public FInputScaleBiasClampConstants PlayRateScaleBiasClampConstants;
	public float StartPosition;
	public bool bLoopAnimation;
	public bool bStartFromMatchingPose;
}
