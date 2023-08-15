namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Triggers an animation notify.  Each AnimNotifyEvent contains an AnimNotify object</summary>
[CppInclude("Animation/AnimTypes.h")]
public partial struct FAnimNotifyEvent {
	public float DisplayTime_DEPRECATED;
	public float TriggerTimeOffset;
	public float EndTriggerTimeOffset;
	public float TriggerWeightThreshold;
	public FName NotifyName;
	public UAnimNotify Notify;
	public UAnimNotifyState NotifyStateClass;
	public float Duration;
	public FAnimLinkableElement EndLink;
	public bool bConvertedFromBranchingPoint;
	public EMontageNotifyTickType MontageTickType;
	public float NotifyTriggerChance;
	public ENotifyFilterType NotifyFilterType;
	public int NotifyFilterLOD;
	public bool bTriggerOnDedicatedServer;
	public bool bTriggerOnFollower;
	public FColor NotifyColor;
	public FGuid Guid;
	public int TrackIndex;
}
