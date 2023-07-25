#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_SpawnActor.h")]
///<summary>Convenience task for spawning actors on the network authority. If not the net authority, we will not spawn and Success will not be called.</summary>
public partial class UAbilityTask_SpawnActor : UAbilityTask {
// AbilityTask_SpawnActor
	public FSpawnActorDelegate Success;
	public FSpawnActorDelegate DidNotSpawn;
	public UObject SpawnActor(UObject OwningAbility,FGameplayAbilityTargetDataHandle TargetData,UClass Class) { return default; }
	public bool BeginSpawningActor(UObject OwningAbility,FGameplayAbilityTargetDataHandle TargetData,UClass Class,UObject SpawnedActor) { return default; }
	public void FinishSpawningActor(UObject OwningAbility,FGameplayAbilityTargetDataHandle TargetData,UObject SpawnedActor) {}
}
