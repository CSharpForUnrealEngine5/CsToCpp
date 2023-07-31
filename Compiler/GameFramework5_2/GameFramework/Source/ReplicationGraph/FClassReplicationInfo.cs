#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-Class actor data about how the actor replicates</summary>
[CppInclude("ReplicationGraphTypes.h")]
public partial struct FClassReplicationInfo {
	public float DistancePriorityScale;
	public float StarvationPriorityScale;
	public float AccumulatedNetPriorityBias;
	public ushort ReplicationPeriodFrame;
	public ushort FastPath_ReplicationPeriodFrame;
	public ushort ActorChannelFrameTimeout;
	public float CullDistance;
	public float CullDistanceSquared;
}
