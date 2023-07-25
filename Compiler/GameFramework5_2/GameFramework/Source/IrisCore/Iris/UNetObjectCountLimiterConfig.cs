#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/Prioritization/NetObjectCountLimiter.h")]
public partial class UNetObjectCountLimiterConfig : UNetObjectPrioritizerConfig {
// NetObjectCountLimiterConfig
	public ENetObjectCountLimiterMode Mode;
	public uint MaxObjectCount;
	public float Priority;
	public float OwningConnectionPriority;
	public bool bEnableOwnedObjectsFastLane;
}
