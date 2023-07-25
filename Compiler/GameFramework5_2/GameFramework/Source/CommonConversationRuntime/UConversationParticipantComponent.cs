#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationParticipantComponent.h")]
///<summary>Active conversation participants should have this component on them.</summary>
public partial class UConversationParticipantComponent : UActorComponent {
// ConversationParticipantComponent
	public void RequestServerAdvanceConversation(FAdvanceConversationRequest InChoicePicked) {}
	public string GetParticipantDisplayName() { return default; }
	public bool IsInActiveConversation() { return default; }
	public void ServerAdvanceConversation(FAdvanceConversationRequest InChoicePicked) {}
	public void ClientUpdateParticipants(FConversationParticipants InParticipants) {}
	public void ClientExecuteTaskAndSideEffects(FConversationNodeHandle Handle) {}
	public void ClientUpdateConversation(FClientConversationMessagePayload Message) {}
	public void ClientUpdateConversationTaskChoiceData(FConversationNodeHandle Handle,FClientConversationOptionEntry OptionEntry) {}
	public void ClientUpdateConversations(int InConversationsActive) {}
	public void ClientStartConversation(FGameplayTag AsParticipant) {}
	public void OnRep_ConversationsActive(int OldConversationsActive) {}
	public int ConversationsActive;
	public UConversationInstance Auth_CurrentConversation;
	public TArray<UConversationInstance> Auth_Conversations;
	public FClientConversationMessagePayload LastMessage;
}
