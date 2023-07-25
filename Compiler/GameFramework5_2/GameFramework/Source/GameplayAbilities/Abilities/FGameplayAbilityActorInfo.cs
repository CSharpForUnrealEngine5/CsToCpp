#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTypes.h")]
///<summary>FGameplayAbilityActorInfo</summary>
public partial struct FGameplayAbilityActorInfo {
// GameplayAbilityActorInfo
	public TWeakObjectPtr<AActor> OwnerActor;
	public TWeakObjectPtr<AActor> AvatarActor;
	public TWeakObjectPtr<APlayerController> PlayerController;
	public TWeakObjectPtr<UAbilitySystemComponent> AbilitySystemComponent;
	public TWeakObjectPtr<USkeletalMeshComponent> SkeletalMeshComponent;
	public TWeakObjectPtr<UAnimInstance> AnimInstance;
	public TWeakObjectPtr<UMovementComponent> MovementComponent;
	public string AffectedAnimInstanceTag;
}
