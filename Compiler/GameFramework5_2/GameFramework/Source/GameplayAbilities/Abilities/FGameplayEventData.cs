#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTypes.h")]
///<summary>Metadata for a tag-based Gameplay Event, that can activate other abilities or run ability-specific logic</summary>
public partial struct FGameplayEventData {
// GameplayEventData
	public FGameplayTag EventTag;
	public AActor Instigator;
	public AActor Target;
	public UObject OptionalObject;
	public UObject OptionalObject2;
	public FGameplayEffectContextHandle ContextHandle;
	public FGameplayTagContainer InstigatorTags;
	public FGameplayTagContainer TargetTags;
	public float EventMagnitude;
	public FGameplayAbilityTargetDataHandle TargetData;
}
