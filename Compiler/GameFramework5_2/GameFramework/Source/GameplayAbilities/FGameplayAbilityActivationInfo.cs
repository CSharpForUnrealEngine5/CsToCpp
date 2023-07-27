#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayAbilitySpec.h")]
///<summary>FGameplayAbilityActivationInfo</summary>
public partial struct FGameplayAbilityActivationInfo {
// GameplayAbilityActivationInfo
	public EGameplayAbilityActivationMode ActivationMode;
	public bool bCanBeEndedByOtherInstance;
	public FPredictionKey PredictionKeyWhenActivated;
}
