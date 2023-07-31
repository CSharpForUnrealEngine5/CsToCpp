#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sequence player node that can be used with constant folding</summary>
[CppInclude("Animation/AnimNode_SequencePlayer.h")]
public partial struct FAnimNode_SequencePlayer {
	public string GroupName;
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
