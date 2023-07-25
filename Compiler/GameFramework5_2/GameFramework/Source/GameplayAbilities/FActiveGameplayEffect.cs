#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Active GameplayEffect instance</summary>
public partial struct FActiveGameplayEffect {
// ActiveGameplayEffect
	public FGameplayEffectSpec Spec;
	public FPredictionKey PredictionKey;
	public float StartServerWorldTime;
	public float CachedStartServerWorldTime;
	public float StartWorldTime;
	public bool bIsInhibited;
}
