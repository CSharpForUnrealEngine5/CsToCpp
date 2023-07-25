#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>This is a cut down version of the gameplay effect spec used for RPCs.</summary>
public partial struct FGameplayEffectSpecForRPC {
// GameplayEffectSpecForRPC
	public UGameplayEffect Def;
	public TArray<FGameplayEffectModifiedAttribute> ModifiedAttributes;
	public FGameplayEffectContextHandle EffectContext;
	public FGameplayTagContainer AggregatedSourceTags;
	public FGameplayTagContainer AggregatedTargetTags;
	public float Level;
	public float AbilityLevel;
}
