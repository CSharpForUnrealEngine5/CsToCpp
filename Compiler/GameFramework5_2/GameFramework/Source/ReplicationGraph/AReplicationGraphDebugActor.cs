#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReplicationGraph.h")]
///<summary>Specialized actor for replicating debug information about replication to specific connections. This actor is never spawned in shipping builds and never counts towards bandwidth limits</summary>
public partial class AReplicationGraphDebugActor : AActor {
// ReplicationGraphDebugActor
	public UReplicationGraph ReplicationGraph;
	public  void ServerStartDebugging() {}
	public  void ServerStopDebugging() {}
	public  void ServerCellInfo() {}
	public  void ServerPrintAllActorInfo(string Str) {}
	public  void ServerSetCullDistanceForClass(UClass Class,float CullDistance) {}
	public  void ServerSetPeriodFrameForClass(UClass Class,int PeriodFrame) {}
	public  void ServerSetConditionalActorBreakpoint(AActor Actor) {}
	public  void ServerPrintCullDistances() {}
	public  void ClientCellInfo(FVector CellLocation,FVector CellExtent,TArray<AActor> Actors) {}
	public UNetReplicationGraphConnection ConnectionManager;
}
