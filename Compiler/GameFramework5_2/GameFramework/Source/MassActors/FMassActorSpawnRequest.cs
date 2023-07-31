#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all spawn request</summary>
[CppInclude("MassActorSpawnerSubsystem.h")]
public partial struct FMassActorSpawnRequest {
	public UClass Template;
	public AActor SpawnedActor;
}
