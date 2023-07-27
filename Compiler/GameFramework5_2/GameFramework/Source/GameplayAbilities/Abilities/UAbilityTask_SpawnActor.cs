#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_SpawnActor.h")]
///<summary>Convenience task for spawning actors on the network authority. If not the net authority, we will not spawn and Success will not be called.</summary>
public partial class UAbilityTask_SpawnActor : UAbilityTask {
// AbilityTask_SpawnActor
	public FSpawnActorDelegate Success;
	public FSpawnActorDelegate DidNotSpawn;
	public static UAbilityTask_SpawnActor SpawnActor(UGameplayAbility OwningAbility,FGameplayAbilityTargetDataHandle TargetData,UClass Class) { return default; }
	public  bool BeginSpawningActor(UGameplayAbility OwningAbility,FGameplayAbilityTargetDataHandle TargetData,UClass Class,AActor SpawnedActor) { return default; }
	public  void FinishSpawningActor(UGameplayAbility OwningAbility,FGameplayAbilityTargetDataHandle TargetData,AActor SpawnedActor) {}
}
