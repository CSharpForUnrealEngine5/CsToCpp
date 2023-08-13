namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A basic implementation of replication graph. It only supports NetCullDistanceSquared, bAlwaysRelevant, bOnlyRelevantToOwner. These values cannot change per-actor at runtime.</summary>
[CppInclude("BasicReplicationGraph.h")]
public partial class UBasicReplicationGraph : UReplicationGraph {
	public static UClass StaticClass() {return default;}
	///<summary>GridNode</summary>
	public UReplicationGraphNode_GridSpatialization2D GridNode;
	///<summary>AlwaysRelevantNode</summary>
	public UReplicationGraphNode_ActorList AlwaysRelevantNode;
	///<summary>AlwaysRelevantForConnectionList</summary>
	public TArray<FConnectionAlwaysRelevantNodePair> AlwaysRelevantForConnectionList;
	///<summary>Actors that are only supposed to replicate to their owning connection, but that did not have a connection on spawn</summary>
	public TArray<AActor> ActorsWithoutNetConnection;
}
