#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReplicationGraph.h")]
///<summary>Adds actors that are always relevant for a connection. This engine version just adds the PlayerController and ViewTarget (usually the pawn)</summary>
public partial class UReplicationGraphNode_AlwaysRelevant_ForConnection : UReplicationGraphNode_ActorList {
// ReplicationGraphNode_AlwaysRelevant_ForConnection
	public TArray<FAlwaysRelevantActorInfo> PastRelevantActors;
}
