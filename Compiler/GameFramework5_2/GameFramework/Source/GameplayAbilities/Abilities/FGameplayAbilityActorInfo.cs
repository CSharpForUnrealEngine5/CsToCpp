#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayAbilityActorInfo</summary>
[CppInclude("Abilities/GameplayAbilityTypes.h")]
public partial struct FGameplayAbilityActorInfo {
	public TWeakObjectPtr<AActor> OwnerActor;
	public TWeakObjectPtr<AActor> AvatarActor;
	public TWeakObjectPtr<APlayerController> PlayerController;
	public TWeakObjectPtr<UAbilitySystemComponent> AbilitySystemComponent;
	public TWeakObjectPtr<USkeletalMeshComponent> SkeletalMeshComponent;
	public TWeakObjectPtr<UAnimInstance> AnimInstance;
	public TWeakObjectPtr<UMovementComponent> MovementComponent;
	public string AffectedAnimInstanceTag;
}
