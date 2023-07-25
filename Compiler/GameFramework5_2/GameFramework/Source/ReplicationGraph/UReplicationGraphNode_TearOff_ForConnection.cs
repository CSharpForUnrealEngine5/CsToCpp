#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReplicationGraph.h")]
///<summary>Manages actors that are Tear Off. We will try to replicate these actors one last time to each connection.</summary>
public partial class UReplicationGraphNode_TearOff_ForConnection : UReplicationGraphNode {
// ReplicationGraphNode_TearOff_ForConnection
	public TArray<FTearOffActorInfo> TearOffActors;
}
