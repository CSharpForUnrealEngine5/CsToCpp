#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/GameplayTask_SpawnActor.h")]
///<summary>Convenience task for spawning actors (optionally limiting the spawning to the network authority). If not the net authority, we will not spawn</summary>
public partial class UGameplayTask_SpawnActor : UGameplayTask {
// GameplayTask_SpawnActor
	public FGameplayTaskSpawnActorDelegate Success;
	public FGameplayTaskSpawnActorDelegate DidNotSpawn;
	public UObject SpawnActor(object /*TaskOwner*/ TaskOwner,FVector SpawnLocation,FRotator SpawnRotation,UClass Class,bool bSpawnOnlyOnAuthority/*=false*/) { return default; }
	public bool BeginSpawningActor(UObject WorldContextObject,UObject SpawnedActor) { return default; }
	public void FinishSpawningActor(UObject WorldContextObject,UObject SpawnedActor) {}
	public UClass ClassToSpawn;
}
