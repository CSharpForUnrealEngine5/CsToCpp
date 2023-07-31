#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Task to send event to a specified Smart Object Slot based on the tasks lifetime.</summary>
[CppInclude("StateTree/GameplayInteractionSendSlotEventTask.h")]
public partial struct FGameplayInteractionSendSlotEventTask {
	public FGameplayTag EventTag;
	public FInstancedStruct Payload;
	public EGameplayInteractionTaskTrigger Trigger;
}
