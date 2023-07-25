#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReplicationGraphTypes.h")]
///<summary>Per-Class actor data about how the actor replicates</summary>
public partial struct FClassReplicationInfo {
// ClassReplicationInfo
	public float DistancePriorityScale;
	public float StarvationPriorityScale;
	public float AccumulatedNetPriorityBias;
	public ushort ReplicationPeriodFrame;
	public ushort FastPath_ReplicationPeriodFrame;
	public ushort ActorChannelFrameTimeout;
	public float CullDistance;
	public float CullDistanceSquared;
}
