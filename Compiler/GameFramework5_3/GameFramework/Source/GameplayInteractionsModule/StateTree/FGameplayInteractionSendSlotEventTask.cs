namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Task to send event to a specified Smart Object Slot based on the tasks lifetime.</summary>
[CppInclude("StateTree/GameplayInteractionSendSlotEventTask.h")]
public partial struct FGameplayInteractionSendSlotEventTask {
	public FGameplayTag EventTag;
	public FInstancedStruct Payload;
	public EGameplayInteractionTaskTrigger Trigger;
	public bool bHandleExternalStopAsFailure;
	public bool bShouldTriggerOnReselect;
}
