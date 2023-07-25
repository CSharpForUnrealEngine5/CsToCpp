#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Tasks/BTTask_SetTagCooldown.h")]
///<summary>Cooldown task node.</summary>
public partial class UBTTask_SetTagCooldown : UBTTaskNode {
// BTTask_SetTagCooldown
	public FGameplayTag CooldownTag;
	public bool bAddToExistingDuration;
	public float CooldownDuration;
}
