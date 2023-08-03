#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A gameplay ability that plays a single montage and applies a GameplayEffect</summary>
[CppInclude("Abilities/GameplayAbility_Montage.h")]
public partial class UGameplayAbility_Montage : UGameplayAbility {
	public static UClass StaticClass() {return default;}
	///<summary>MontageToPlay</summary>
	public UAnimMontage MontageToPlay;
	///<summary>PlayRate</summary>
	public float PlayRate;
	///<summary>SectionName</summary>
	public string SectionName;
	///<summary>GameplayEffects to apply and then remove while the animation is playing</summary>
	public TArray<UClass> GameplayEffectClassesWhileAnimating;
	///<summary>Deprecated. Use GameplayEffectClassesWhileAnimating instead.</summary>
	public TArray<UGameplayEffect> GameplayEffectsWhileAnimating;
}
