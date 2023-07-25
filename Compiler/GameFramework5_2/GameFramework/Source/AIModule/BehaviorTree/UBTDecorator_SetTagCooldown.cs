#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Decorators/BTDecorator_SetTagCooldown.h")]
///<summary>Set tag cooldown decorator node.</summary>
public partial class UBTDecorator_SetTagCooldown : UBTDecorator {
// BTDecorator_SetTagCooldown
	public FGameplayTag CooldownTag;
	public float CooldownDuration;
	public bool bAddToExistingDuration;
}
