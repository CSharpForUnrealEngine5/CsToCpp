#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectTypes.h")]
///<summary>Metadata about a gameplay cue execution</summary>
public partial struct FGameplayCueParameters {
// GameplayCueParameters
	public float NormalizedMagnitude;
	public float RawMagnitude;
	public FGameplayEffectContextHandle EffectContext;
	public FGameplayTag MatchedTagName;
	public FGameplayTag OriginalTag;
	public FGameplayTagContainer AggregatedSourceTags;
	public FGameplayTagContainer AggregatedTargetTags;
	public FVector_NetQuantize10 Location;
	public FVector_NetQuantizeNormal Normal;
	public TWeakObjectPtr<AActor> Instigator;
	public TWeakObjectPtr<AActor> EffectCauser;
	public TWeakObjectPtr<UObject> SourceObject;
	public TWeakObjectPtr<UPhysicalMaterial> PhysicalMaterial;
	public int GameplayEffectLevel;
	public int AbilityLevel;
	public TWeakObjectPtr<USceneComponent> TargetAttachComponent;
	public bool bReplicateLocationWhenUsingMinimalRepProxy;
}
