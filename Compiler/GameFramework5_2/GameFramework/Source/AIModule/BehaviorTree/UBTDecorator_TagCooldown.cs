#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Decorators/BTDecorator_TagCooldown.h")]
///<summary>Cooldown decorator node.</summary>
public partial class UBTDecorator_TagCooldown : UBTDecorator {
// BTDecorator_TagCooldown
	public FGameplayTag CooldownTag;
	public float CooldownDuration;
	public bool bAddToExistingDuration;
	public bool bActivatesCooldown;
}
