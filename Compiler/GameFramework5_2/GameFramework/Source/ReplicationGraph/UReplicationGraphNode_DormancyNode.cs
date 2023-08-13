namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores per-connection copies of a main actor list. Skips and removes elements from per connection list that are fully dormant</summary>
[CppInclude("ReplicationGraph.h")]
public partial class UReplicationGraphNode_DormancyNode : UReplicationGraphNode_ActorList {
	public static UClass StaticClass() {return default;}
}
