#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_SequencePlayer.h")]
///<summary>Sequence player node that can be used standalone (without constant folding)</summary>
public partial struct FAnimNode_SequencePlayer_Standalone {
// AnimNode_SequencePlayer_Standalone
	public string GroupName;
	public byte GroupRole;
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
