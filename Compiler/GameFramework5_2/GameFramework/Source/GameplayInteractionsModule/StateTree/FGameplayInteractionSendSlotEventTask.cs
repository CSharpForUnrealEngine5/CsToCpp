#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTree/GameplayInteractionSendSlotEventTask.h")]
///<summary>Task to send event to a specified Smart Object Slot based on the tasks lifetime.</summary>
public partial struct FGameplayInteractionSendSlotEventTask {
// GameplayInteractionSendSlotEventTask
	public FGameplayTag EventTag;
	public FInstancedStruct Payload;
	public EGameplayInteractionTaskTrigger Trigger;
}
