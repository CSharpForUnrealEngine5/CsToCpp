namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayEffectCue</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FGameplayEffectCue {
	public FGameplayAttribute MagnitudeAttribute;
	public float MinLevel;
	public float MaxLevel;
	public FGameplayTagContainer GameplayCueTags;
}
