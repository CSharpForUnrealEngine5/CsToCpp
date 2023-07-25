#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTargetActor.h")]
///<summary>TargetActors are spawned to assist with ability targeting. They are spawned by ability tasks and create/determine the outgoing targeting data passed from one task to another</summary>
public partial class AGameplayAbilityTargetActor : AActor {
// GameplayAbilityTargetActor
	public bool ShouldProduceTargetDataOnServer;
	public FGameplayAbilityTargetingLocationInfo StartLocation;
	public void ConfirmTargeting() {}
	public void CancelTargeting() {}
	public APlayerController PrimaryPC;
	public UGameplayAbility OwningAbility;
	public bool bDestroyOnConfirmation;
	public AActor SourceActor;
	public FWorldReticleParameters ReticleParams;
	public UClass ReticleClass;
	public FGameplayTargetDataFilterHandle Filter;
	public bool bDebug;
	public UAbilitySystemComponent GenericDelegateBoundASC;
}
