#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds actors that are always relevant for a connection. This engine version just adds the PlayerController and ViewTarget (usually the pawn)</summary>
[CppInclude("ReplicationGraph.h")]
public partial class UReplicationGraphNode_AlwaysRelevant_ForConnection : UReplicationGraphNode_ActorList {
	public static UClass StaticClass() {return default;}
	///<summary>PastRelevantActors</summary>
	public TArray<FAlwaysRelevantActorInfo> PastRelevantActors;
}
