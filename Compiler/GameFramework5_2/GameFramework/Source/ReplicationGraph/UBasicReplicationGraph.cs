#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BasicReplicationGraph.h")]
///<summary>A basic implementation of replication graph. It only supports NetCullDistanceSquared, bAlwaysRelevant, bOnlyRelevantToOwner. These values cannot change per-actor at runtime.</summary>
public partial class UBasicReplicationGraph : UReplicationGraph {
// BasicReplicationGraph
	public UReplicationGraphNode_GridSpatialization2D GridNode;
	public UReplicationGraphNode_ActorList AlwaysRelevantNode;
	public TArray<FConnectionAlwaysRelevantNodePair> AlwaysRelevantForConnectionList;
	public TArray<AActor> ActorsWithoutNetConnection;
}
