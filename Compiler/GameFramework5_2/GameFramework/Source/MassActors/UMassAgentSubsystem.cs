#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassAgentSubsystem.h")]
///<summary>A subsystem managing communication between Actors and Mass</summary>
public partial class UMassAgentSubsystem : UWorldSubsystem {
// MassAgentSubsystem
	public UMassSpawnerSubsystem SpawnerSystem;
	public UMassSimulationSubsystem SimulationSystem;
	public TMap<FMassEntityTemplateID,FMassAgentInitializationQueue> PendingAgentEntities;
	public TMap<FMassEntityTemplateID,FMassAgentInitializationQueue> PendingPuppets;
	public UMassReplicationSubsystem ReplicationSubsystem;
	public TMap<FMassNetworkID,UMassAgentComponent> ReplicatedAgentComponents;
}
