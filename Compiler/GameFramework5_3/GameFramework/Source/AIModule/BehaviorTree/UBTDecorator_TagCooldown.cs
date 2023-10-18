namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cooldown decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_TagCooldown.h")]
public partial class UBTDecorator_TagCooldown : UBTDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>Gameplay tag that will be used for the cooldown.</summary>
	public FGameplayTag CooldownTag;
	///<summary>Value we will add or set to the Cooldown tag when this node is deactivated.</summary>
	public float CooldownDuration;
	///<summary>True if we are adding to any existing duration, false if we are setting the duration (potentially invalidating an existing end time).</summary>
	public bool bAddToExistingDuration;
	///<summary>Whether or not we are adding/setting to the cooldown tag&#39;s value when the decorator deactivates.</summary>
	public bool bActivatesCooldown;
}
