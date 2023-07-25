#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Active GameplayEffects Container</summary>
public partial struct FActiveGameplayEffectsContainer {
// ActiveGameplayEffectsContainer
	public TArray<FActiveGameplayEffect> GameplayEffects_Internal;
	public TArray<UGameplayEffect> ApplicationImmunityQueryEffects;
}
