namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Ability Ended Data</summary>
[CppInclude("Abilities/GameplayAbilityTypes.h")]
public partial struct FAbilityEndedData {
	public UGameplayAbility AbilityThatEnded;
	public FGameplayAbilitySpecHandle AbilitySpecHandle;
	public bool bReplicateEndAbility;
	public bool bWasCancelled;
}
