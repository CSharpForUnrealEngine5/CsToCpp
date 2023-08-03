#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set tag cooldown decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_SetTagCooldown.h")]
public partial class UBTDecorator_SetTagCooldown : UBTDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>Gameplay tag that will be used for the cooldown.</summary>
	public FGameplayTag CooldownTag;
	///<summary>Value we will add or set to the Cooldown tag when this task runs.</summary>
	public float CooldownDuration;
	///<summary>True if we are adding to any existing duration, false if we are setting the duration (potentially invalidating an existing end time).</summary>
	public bool bAddToExistingDuration;
}
