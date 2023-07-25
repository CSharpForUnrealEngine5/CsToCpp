#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectTypes.h")]
///<summary>Data structure that stores an instigator and related data, such as positions and targets</summary>
public partial struct FGameplayEffectContext {
// GameplayEffectContext
	public TWeakObjectPtr<AActor> Instigator;
	public TWeakObjectPtr<AActor> EffectCauser;
	public TWeakObjectPtr<UGameplayAbility> AbilityCDO;
	public TWeakObjectPtr<UGameplayAbility> AbilityInstanceNotReplicated;
	public int AbilityLevel;
	public TWeakObjectPtr<UObject> SourceObject;
	public TWeakObjectPtr<UAbilitySystemComponent> InstigatorAbilitySystemComponent;
	public TArray<TWeakObjectPtr<AActor>> Actors;
	public FVector WorldOrigin;
	public bool bHasWorldOrigin;
	public bool bReplicateSourceObject;
	public bool bReplicateInstigator;
	public bool bReplicateEffectCauser;
}
