#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbility.h")]
///<summary>Structure that defines how an ability will be triggered by external events</summary>
public partial struct FAbilityTriggerData {
// AbilityTriggerData
	public FGameplayTag TriggerTag;
	public byte TriggerSource;
}
