#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationContext.h")]
///<summary>The conversation task result type gives the conversation system the instruction it needs</summary>
public enum EConversationTaskResultType {
	Invalid=0,
	AbortConversation=1,
	AdvanceConversation=2,
	AdvanceConversationWithChoice=3,
	PauseConversationAndSendClientChoices=4,
	ReturnToLastClientChoice=5,
	ReturnToCurrentClientChoice=6,
	ReturnToConversationStart=7,
}
