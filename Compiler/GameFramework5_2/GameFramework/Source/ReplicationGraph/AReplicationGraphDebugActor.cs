#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specialized actor for replicating debug information about replication to specific connections. This actor is never spawned in shipping builds and never counts towards bandwidth limits</summary>
[CppInclude("ReplicationGraph.h")]
public partial class AReplicationGraphDebugActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>ReplicationGraph</summary>
	public UReplicationGraph ReplicationGraph;
	///<summary>ServerStartDebugging</summary>
	public  void ServerStartDebugging() {}
	///<summary>ServerStopDebugging</summary>
	public  void ServerStopDebugging() {}
	///<summary>ServerCellInfo</summary>
	public  void ServerCellInfo() {}
	///<summary>ServerPrintAllActorInfo</summary>
	public  void ServerPrintAllActorInfo(string Str) {}
	///<summary>ServerSetCullDistanceForClass</summary>
	public  void ServerSetCullDistanceForClass(UClass Class,float CullDistance) {}
	///<summary>ServerSetPeriodFrameForClass</summary>
	public  void ServerSetPeriodFrameForClass(UClass Class,int PeriodFrame) {}
	///<summary>ServerSetConditionalActorBreakpoint</summary>
	public  void ServerSetConditionalActorBreakpoint(AActor Actor) {}
	///<summary>ServerPrintCullDistances</summary>
	public  void ServerPrintCullDistances() {}
	///<summary>ClientCellInfo</summary>
	public  void ClientCellInfo(FVector CellLocation,FVector CellExtent,TArray<AActor> Actors) {}
	///<summary>ConnectionManager</summary>
	public UNetReplicationGraphConnection ConnectionManager;
}
