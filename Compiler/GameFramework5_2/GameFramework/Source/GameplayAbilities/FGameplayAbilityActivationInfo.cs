#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayAbilityActivationInfo</summary>
[CppInclude("GameplayAbilitySpec.h")]
public partial struct FGameplayAbilityActivationInfo {
	public EGameplayAbilityActivationMode ActivationMode;
	public bool bCanBeEndedByOtherInstance;
	public FPredictionKey PredictionKeyWhenActivated;
}
