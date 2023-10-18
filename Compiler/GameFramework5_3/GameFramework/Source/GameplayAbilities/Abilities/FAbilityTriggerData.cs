namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that defines how an ability will be triggered by external events</summary>
[CppInclude("Abilities/GameplayAbility.h")]
public partial struct FAbilityTriggerData {
	public FGameplayTag TriggerTag;
	public EGameplayAbilityTriggerSource TriggerSource;
}
