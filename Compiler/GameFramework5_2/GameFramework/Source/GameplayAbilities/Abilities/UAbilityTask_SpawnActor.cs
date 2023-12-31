namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Convenience task for spawning actors on the network authority. If not the net authority, we will not spawn and Success will not be called.</summary>
[CppInclude("Abilities/Tasks/AbilityTask_SpawnActor.h")]
public partial class UAbilityTask_SpawnActor : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>Success</summary>
	public FSpawnActorDelegate Success;
	///<summary>Called when we can&#39;t spawn: on clients or potentially on server if they fail to spawn (rare)</summary>
	public FSpawnActorDelegate DidNotSpawn;
	///<summary>Spawn new Actor on the network authority (server)</summary>
	public static UAbilityTask_SpawnActor SpawnActor(UGameplayAbility OwningAbility,FGameplayAbilityTargetDataHandle TargetData,UClass Class) { return default; }
	///<summary>BeginSpawningActor</summary>
	public bool BeginSpawningActor(UGameplayAbility OwningAbility,FGameplayAbilityTargetDataHandle TargetData,UClass Class,AActor SpawnedActor) { return default; }
	///<summary>FinishSpawningActor</summary>
	public void FinishSpawningActor(UGameplayAbility OwningAbility,FGameplayAbilityTargetDataHandle TargetData,AActor SpawnedActor) {}
}
