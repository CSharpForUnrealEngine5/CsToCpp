#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReplicationGraph.h")]
///<summary>Manages actor replication for a specific connection</summary>
public partial class UNetReplicationGraphConnection : UReplicationConnectionDriver {
// NetReplicationGraphConnection
	public UNetConnection NetConnection;
	public TWeakObjectPtr<AReplicationGraphDebugActor> DebugActor;
	public TArray<FLastLocationGatherInfo> LastGatherLocations;
	public TArray<UReplicationGraphNode> ConnectionGraphNodes;
	public UReplicationGraphNode_TearOff_ForConnection TearOffNode;
}
