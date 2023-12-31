namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A subsystem managing communication between Actors and Mass</summary>
[CppInclude("MassAgentSubsystem.h")]
public partial class UMassAgentSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>SpawnerSystem</summary>
	public UMassSpawnerSubsystem SpawnerSystem;
	///<summary>SimulationSystem</summary>
	public UMassSimulationSubsystem SimulationSystem;
	///<summary>PendingAgentEntities</summary>
	public TMap<FMassEntityTemplateID,FMassAgentInitializationQueue> PendingAgentEntities;
	///<summary>PendingPuppets</summary>
	public TMap<FMassEntityTemplateID,FMassAgentInitializationQueue> PendingPuppets;
	///<summary>ReplicationSubsystem</summary>
	public UMassReplicationSubsystem ReplicationSubsystem;
	///<summary>ReplicatedAgentComponents</summary>
	public TMap<FMassNetworkID,UMassAgentComponent> ReplicatedAgentComponents;
}
