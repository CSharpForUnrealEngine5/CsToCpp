namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all spawn request</summary>
[CppInclude("MassActorSpawnerSubsystem.h")]
public partial struct FMassActorSpawnRequest {
	public UClass Template;
	public AActor SpawnedActor;
}
