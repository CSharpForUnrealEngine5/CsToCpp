namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used as a key for storing internal ability data</summary>
[CppInclude("Abilities/GameplayAbilityTypes.h")]
public partial struct FGameplayAbilitySpecHandleAndPredictionKey {
	public FGameplayAbilitySpecHandle AbilityHandle;
	public int PredictionKeyAtCreation;
}
