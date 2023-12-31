namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Node that contains ReplicateActorLists. This contains multiple buckets for non streaming level actors and will pull from each bucket on alternating frames. It is a way to broadly load balance.</summary>
[CppInclude("ReplicationGraph.h")]
public partial class UReplicationGraphNode_ActorListFrequencyBuckets : UReplicationGraphNode {
	public static UClass StaticClass() {return default;}
}
