#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTargetTypes.h")]
///<summary>Describes how the targeting information is confirmed</summary>
[CppEnumInNamespace]
public enum EGameplayTargetingConfirmation {
	Instant=0,
	UserConfirmed=1,
	Custom=2,
	CustomMulti=3,
}
