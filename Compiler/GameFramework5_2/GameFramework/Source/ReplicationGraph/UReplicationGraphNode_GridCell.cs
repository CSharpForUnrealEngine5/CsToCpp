namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReplicationGraph.h")]
public partial class UReplicationGraphNode_GridCell : UReplicationGraphNode_ActorList {
	public static UClass StaticClass() {return default;}
	///<summary>DynamicNode</summary>
	public UReplicationGraphNode DynamicNode;
	///<summary>DormancyNode</summary>
	public UReplicationGraphNode_DormancyNode DormancyNode;
}
