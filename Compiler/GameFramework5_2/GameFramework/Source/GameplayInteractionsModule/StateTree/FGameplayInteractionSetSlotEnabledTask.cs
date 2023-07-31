#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Task to set a Smart Object Slot enabled to disabled.</summary>
[CppInclude("StateTree/GameplayInteractionSetSlotEnabledTask.h")]
public partial struct FGameplayInteractionSetSlotEnabledTask {
	public EGameplayInteractionTaskModify Modify;
	public bool bEnableSlot;
}
