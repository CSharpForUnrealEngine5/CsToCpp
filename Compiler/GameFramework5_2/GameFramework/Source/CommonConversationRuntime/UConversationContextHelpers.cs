#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationContext.h")]
///<summary>Wrapper methods from FConversationContext</summary>
public partial class UConversationContextHelpers : UBlueprintFunctionLibrary {
// ConversationContextHelpers
	public UObject GetConversationInstance(FConversationContext Context) { return default; }
	public FConversationNodeHandle GetCurrentConversationNodeHandle(FConversationContext Context) { return default; }
	public void MakeConversationParticipant(FConversationContext Context,UObject ParticipantActor,FGameplayTag ParticipantTag) {}
	public FConversationTaskResult AdvanceConversation(FConversationContext Context) { return default; }
	public FConversationTaskResult AdvanceConversationWithChoice(FConversationContext Context,FAdvanceConversationRequest Choice) { return default; }
	public FConversationTaskResult PauseConversationAndSendClientChoices(FConversationContext Context,FClientConversationMessage Message) { return default; }
	public FConversationTaskResult ReturnToLastClientChoice(FConversationContext Context) { return default; }
	public FConversationTaskResult ReturnToCurrentClientChoice(FConversationContext Context) { return default; }
	public FConversationTaskResult ReturnToConversationStart(FConversationContext Context) { return default; }
	public FConversationTaskResult AbortConversation(FConversationContext Context) { return default; }
	public bool CanConversationContinue(FConversationTaskResult ConversationTasResult) { return default; }
	public UObject GetConversationParticipant(FConversationContext Context,FGameplayTag ParticipantTag) { return default; }
	public UObject GetConversationParticipantActor(FConversationContext Context,FGameplayTag ParticipantTag) { return default; }
	public UObject FindConversationComponent(UObject Actor) { return default; }
}
