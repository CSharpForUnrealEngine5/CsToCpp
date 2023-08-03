#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manages actor replication for a specific connection</summary>
[CppInclude("ReplicationGraph.h")]
public partial class UNetReplicationGraphConnection : UReplicationConnectionDriver {
	public static UClass StaticClass() {return default;}
	///<summary>NetConnection</summary>
	public UNetConnection NetConnection;
	///<summary>DebugActor</summary>
	public TWeakObjectPtr<AReplicationGraphDebugActor> DebugActor;
	///<summary>LastGatherLocations</summary>
	public TArray<FLastLocationGatherInfo> LastGatherLocations;
	///<summary>ConnectionGraphNodes</summary>
	public TArray<UReplicationGraphNode> ConnectionGraphNodes;
	///<summary>TearOffNode</summary>
	public UReplicationGraphNode_TearOff_ForConnection TearOffNode;
}
