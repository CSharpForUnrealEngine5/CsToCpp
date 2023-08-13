namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayAbilityActivationInfo</summary>
[CppInclude("GameplayAbilitySpec.h")]
public partial struct FGameplayAbilityActivationInfo {
	public EGameplayAbilityActivationMode ActivationMode;
	public bool bCanBeEndedByOtherInstance;
	public FPredictionKey PredictionKeyWhenActivated;
}
