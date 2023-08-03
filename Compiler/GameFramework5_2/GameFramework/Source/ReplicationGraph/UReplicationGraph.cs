#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manages actor replication for an entire world / net driver</summary>
[CppInclude("ReplicationGraph.h")]
public partial class UReplicationGraph : UReplicationDriver {
	public static UClass StaticClass() {return default;}
	///<summary>The per-connection manager class to instantiate. This will be read off the instantiated UNetReplicationManager.</summary>
	public UClass ReplicationConnectionManagerClass;
	///<summary>NetDriver</summary>
	public UNetDriver NetDriver;
	///<summary>List of connection managers. This list is not sorted and not stable.</summary>
	public TArray<UNetReplicationGraphConnection> Connections;
	///<summary>ConnectionManagers that we have created but haven&#39;t officially been added to the net driver&#39;s ClientConnection list. This is a  hack for silly order of initialization issues.</summary>
	public TArray<UNetReplicationGraphConnection> PendingConnections;
	///<summary>A list of nodes that can add actors to all connections. They don&#39;t necessarily *have to* add actors to each connection, but they will get a chance to. These are added via ::AddGlobalGraphNode</summary>
	public TArray<UReplicationGraphNode> GlobalGraphNodes;
	///<summary>A list of nodes that want PrepareForReplication() to be called on them at the top of the replication frame.</summary>
	public TArray<UReplicationGraphNode> PrepareForReplicationNodes;
}
