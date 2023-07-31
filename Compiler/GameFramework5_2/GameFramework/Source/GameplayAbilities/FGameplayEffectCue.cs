#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
