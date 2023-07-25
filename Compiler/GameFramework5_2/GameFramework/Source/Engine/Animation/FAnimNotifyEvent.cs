#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimTypes.h")]
///<summary>Triggers an animation notify.  Each AnimNotifyEvent contains an AnimNotify object</summary>
public partial struct FAnimNotifyEvent {
// AnimNotifyEvent
	public float DisplayTime_DEPRECATED;
	public float TriggerTimeOffset;
	public float EndTriggerTimeOffset;
	public float TriggerWeightThreshold;
	public string NotifyName;
	public UAnimNotify Notify;
	public UAnimNotifyState NotifyStateClass;
	public float Duration;
	public FAnimLinkableElement EndLink;
	public bool bConvertedFromBranchingPoint;
	public byte MontageTickType;
	public float NotifyTriggerChance;
	public byte NotifyFilterType;
	public int NotifyFilterLOD;
	public bool bTriggerOnDedicatedServer;
	public bool bTriggerOnFollower;
	public FColor NotifyColor;
	public FGuid Guid;
	public int TrackIndex;
}
