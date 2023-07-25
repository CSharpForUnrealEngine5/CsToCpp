#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTypes.h")]
///<summary>Ability Ended Data</summary>
public partial struct FAbilityEndedData {
// AbilityEndedData
	public UGameplayAbility AbilityThatEnded;
	public FGameplayAbilitySpecHandle AbilitySpecHandle;
	public bool bReplicateEndAbility;
	public bool bWasCancelled;
}
