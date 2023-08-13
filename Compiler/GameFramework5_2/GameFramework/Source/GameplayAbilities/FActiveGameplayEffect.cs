namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Active GameplayEffect instance</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FActiveGameplayEffect {
	public FGameplayEffectSpec Spec;
	public FPredictionKey PredictionKey;
	public float StartServerWorldTime;
	public float CachedStartServerWorldTime;
	public float StartWorldTime;
	public bool bIsInhibited;
}
