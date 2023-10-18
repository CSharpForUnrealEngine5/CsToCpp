namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options on how to configure a GameplayAbilitySpec to grant an Actor</summary>
[CppInclude("GameplayEffectComponents/AbilitiesGameplayEffectComponent.h")]
public partial struct FGameplayAbilitySpecConfig {
	public UClass Ability;
	public FScalableFloat LevelScalableFloat;
	public int InputID;
	public EGameplayEffectGrantedAbilityRemovePolicy RemovalPolicy;
}
