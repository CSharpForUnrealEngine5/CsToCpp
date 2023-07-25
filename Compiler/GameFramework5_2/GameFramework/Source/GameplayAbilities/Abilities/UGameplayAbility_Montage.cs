#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbility_Montage.h")]
///<summary>A gameplay ability that plays a single montage and applies a GameplayEffect</summary>
public partial class UGameplayAbility_Montage : UGameplayAbility {
// GameplayAbility_Montage
	public UAnimMontage MontageToPlay;
	public float PlayRate;
	public string SectionName;
	public TArray<UClass> GameplayEffectClassesWhileAnimating;
	public TArray<UGameplayEffect> GameplayEffectsWhileAnimating;
}
