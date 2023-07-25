#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayAbilitySpec.h")]
///<summary>Describes the status of activating this ability, this is updated as prediction is handled</summary>
public enum EGameplayAbilityActivationMode {
	Authority=0,
	NonAuthority=1,
	Predicting=2,
	Confirmed=3,
	Rejected=4,
}
