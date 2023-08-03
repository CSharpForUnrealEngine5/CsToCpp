#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Convenience task for spawning actors (optionally limiting the spawning to the network authority). If not the net authority, we will not spawn</summary>
[CppInclude("Tasks/GameplayTask_SpawnActor.h")]
public partial class UGameplayTask_SpawnActor : UGameplayTask {
	public static UClass StaticClass() {return default;}
	///<summary>Success</summary>
	public FGameplayTaskSpawnActorDelegate Success;
	///<summary>Called when we can&#39;t spawn: on clients or potentially on server if they fail to spawn (rare)</summary>
	public FGameplayTaskSpawnActorDelegate DidNotSpawn;
	///<summary>Spawn new Actor on the network authority (server)</summary>
	public static UGameplayTask_SpawnActor SpawnActor(object /*TaskOwner*/ TaskOwner,FVector SpawnLocation,FRotator SpawnRotation,UClass Class,bool bSpawnOnlyOnAuthority/*=false*/) { return default; }
	///<summary>BeginSpawningActor</summary>
	public  bool BeginSpawningActor(UObject WorldContextObject,AActor SpawnedActor) { return default; }
	///<summary>FinishSpawningActor</summary>
	public  void FinishSpawningActor(UObject WorldContextObject,AActor SpawnedActor) {}
	///<summary>ClassToSpawn</summary>
	public UClass ClassToSpawn;
}
