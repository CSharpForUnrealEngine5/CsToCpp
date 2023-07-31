#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that defines how an ability will be triggered by external events</summary>
[CppInclude("Abilities/GameplayAbility.h")]
public partial struct FAbilityTriggerData {
	public FGameplayTag TriggerTag;
	public EGameplayAbilityTriggerSource TriggerSource;
}
