namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cooldown task node.</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_SetTagCooldown.h")]
public partial class UBTTask_SetTagCooldown : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>Gameplay tag that will be used for the cooldown.</summary>
	public FGameplayTag CooldownTag;
	///<summary>True if we are adding to any existing duration, false if we are setting the duration (potentially invalidating an existing end time).</summary>
	public bool bAddToExistingDuration;
	///<summary>Value we will add or set to the Cooldown tag when this task runs.</summary>
	public float CooldownDuration;
}
