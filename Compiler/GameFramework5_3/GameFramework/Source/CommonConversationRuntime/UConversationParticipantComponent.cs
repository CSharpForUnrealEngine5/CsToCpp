namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Active conversation participants should have this component on them.</summary>
[CppInclude("ConversationParticipantComponent.h")]
public partial class UConversationParticipantComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>RequestServerAdvanceConversation</summary>
	public void RequestServerAdvanceConversation(FAdvanceConversationRequest InChoicePicked) {}
	///<summary>GetParticipantDisplayName</summary>
	public virtual FText GetParticipantDisplayName() { return default; }
	///<summary>IsInActiveConversation</summary>
	public bool IsInActiveConversation() { return default; }
	///<summary>GetParticipantActor</summary>
	public AActor GetParticipantActor(FGameplayTag ParticipantTag) { return default; }
	///<summary>ServerAdvanceConversation</summary>
	public void ServerAdvanceConversation(FAdvanceConversationRequest InChoicePicked) {}
	///<summary>ClientUpdateParticipants</summary>
	public void ClientUpdateParticipants(FConversationParticipants InParticipants) {}
	///<summary>ClientExecuteTaskAndSideEffects</summary>
	public void ClientExecuteTaskAndSideEffects(FConversationNodeHandle Handle) {}
	///<summary>ClientUpdateConversation</summary>
	public void ClientUpdateConversation(FClientConversationMessagePayload Message) {}
	///<summary>ClientUpdateConversationTaskChoiceData</summary>
	public void ClientUpdateConversationTaskChoiceData(FConversationNodeHandle Handle,FClientConversationOptionEntry OptionEntry) {}
	///<summary>ClientUpdateConversations</summary>
	public void ClientUpdateConversations(int InConversationsActive) {}
	///<summary>ClientStartConversation</summary>
	public void ClientStartConversation(FConversationParticipants InParticipants) {}
	///<summary>ClientExitConversation</summary>
	public void ClientExitConversation(FConversationParticipants InParticipants) {}
	///<summary>OnRep_ConversationsActive</summary>
	public void OnRep_ConversationsActive(int OldConversationsActive) {}
	///<summary>ConversationsActive</summary>
	public int ConversationsActive;
	///<summary>Auth_CurrentConversation</summary>
	public UConversationInstance Auth_CurrentConversation;
	///<summary>Auth_Conversations</summary>
	public TArray<UConversationInstance> Auth_Conversations;
	///<summary>LastMessage</summary>
	public FClientConversationMessagePayload LastMessage;
}
