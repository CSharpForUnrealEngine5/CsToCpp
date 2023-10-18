namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Task to set a Smart Object Slot enabled to disabled.</summary>
[CppInclude("StateTree/GameplayInteractionSetSlotEnabledTask.h")]
public partial struct FGameplayInteractionSetSlotEnabledTask {
	public EGameplayInteractionTaskModify Modify;
	public bool bHandleExternalStopAsFailure;
	public bool bEnableSlot;
}
