#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manages actors that are Tear Off. We will try to replicate these actors one last time to each connection.</summary>
[CppInclude("ReplicationGraph.h")]
public partial class UReplicationGraphNode_TearOff_ForConnection : UReplicationGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>Fixme: not safe to have persistent FActorRepListrefViews yet, so need a uproperty based list to hold the persistent items.</summary>
	public TArray<FTearOffActorInfo> TearOffActors;
}
