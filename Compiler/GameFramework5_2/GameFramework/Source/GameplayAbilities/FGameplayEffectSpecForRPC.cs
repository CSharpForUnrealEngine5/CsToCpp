namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a cut down version of the gameplay effect spec used for RPCs.</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FGameplayEffectSpecForRPC {
	public UGameplayEffect Def;
	public TArray<FGameplayEffectModifiedAttribute> ModifiedAttributes;
	public FGameplayEffectContextHandle EffectContext;
	public FGameplayTagContainer AggregatedSourceTags;
	public FGameplayTagContainer AggregatedTargetTags;
	public float Level;
	public float AbilityLevel;
}
