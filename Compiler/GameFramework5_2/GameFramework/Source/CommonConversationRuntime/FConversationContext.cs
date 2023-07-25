#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationContext.h")]
///<summary>Information about a currently active conversation</summary>
public partial struct FConversationContext {
// ConversationContext
	public UConversationRegistry ConversationRegistry;
	public UConversationInstance ActiveConversation;
	public UConversationParticipantComponent ClientParticipant;
	public UConversationTaskNode TaskBeingConsidered;
	public TArray<FConversationNodeHandle> ReturnScopeStack;
	public bool bServer;
}
