#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReplicationGraph.h")]
///<summary>Manages actor replication for an entire world / net driver</summary>
public partial class UReplicationGraph : UReplicationDriver {
// ReplicationGraph
	public UClass ReplicationConnectionManagerClass;
	public UNetDriver NetDriver;
	public TArray<UNetReplicationGraphConnection> Connections;
	public TArray<UNetReplicationGraphConnection> PendingConnections;
	public TArray<UReplicationGraphNode> GlobalGraphNodes;
	public TArray<UReplicationGraphNode> PrepareForReplicationNodes;
}
