namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Grants additional Gameplay Abilities to the Target of a Gameplay Effect while active</summary>
[CppInclude("GameplayEffectComponents/AbilitiesGameplayEffectComponent.h")]
public partial class UAbilitiesGameplayEffectComponent : UGameplayEffectComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Abilities to Grant to the Target while this Gameplay Effect is active</summary>
	public TArray<FGameplayAbilitySpecConfig> GrantAbilityConfigs;
}
