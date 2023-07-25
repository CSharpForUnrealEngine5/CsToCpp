#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassActorSpawnerSubsystem.h")]
///<summary>A subsystem managing spawning of actors for all mass subsystems</summary>
public partial class UMassActorSpawnerSubsystem : UWorldSubsystem {
// MassActorSpawnerSubsystem
	public TArray<FInstancedStruct> SpawnRequests;
	public TArray<AActor> ActorsToDestroy;
	public TArray<AActor> DeactivatedActorsToDestroy;
}
