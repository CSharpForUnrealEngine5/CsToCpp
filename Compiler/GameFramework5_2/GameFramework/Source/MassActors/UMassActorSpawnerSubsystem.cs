#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A subsystem managing spawning of actors for all mass subsystems</summary>
[CppInclude("MassActorSpawnerSubsystem.h")]
public partial class UMassActorSpawnerSubsystem : UWorldSubsystem {
	///<summary>SpawnRequests</summary>
	public TArray<FInstancedStruct> SpawnRequests;
	///<summary>ActorsToDestroy</summary>
	public TArray<AActor> ActorsToDestroy;
	///<summary>DeactivatedActorsToDestroy</summary>
	public TArray<AActor> DeactivatedActorsToDestroy;
}
