namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayAbilitySpec.h")]
///<summary>Describes what happens when a GameplayEffect, that is granting an active ability, is removed from its owner.</summary>
public enum EGameplayEffectGrantedAbilityRemovePolicy {
	CancelAbilityImmediately=0,
	RemoveAbilityOnEnd=1,
	DoNothing=2,
}
