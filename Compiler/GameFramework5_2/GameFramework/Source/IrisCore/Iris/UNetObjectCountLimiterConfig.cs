#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/Prioritization/NetObjectCountLimiter.h")]
public partial class UNetObjectCountLimiterConfig : UNetObjectPrioritizerConfig {
	public static UClass StaticClass() {return default;}
	///<summary>Mode</summary>
	public ENetObjectCountLimiterMode Mode;
	///<summary>How many objects to be considered for replication each frame.</summary>
	public uint MaxObjectCount;
	///<summary>Which priority to set for objects considered for replication.</summary>
	public float Priority;
	///<summary>The priority to set for a considered object if it&#39;s owned by the connection being prioritized for.</summary>
	public float OwningConnectionPriority;
	///<summary>Whether objects owned by the connection should always be considered for replication.</summary>
	public bool bEnableOwnedObjectsFastLane;
}
