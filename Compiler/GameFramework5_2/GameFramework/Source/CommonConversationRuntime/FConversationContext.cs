namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about a currently active conversation</summary>
[CppInclude("ConversationContext.h")]
public partial struct FConversationContext {
	public UConversationRegistry ConversationRegistry;
	public UConversationInstance ActiveConversation;
	public UConversationParticipantComponent ClientParticipant;
	public UConversationTaskNode TaskBeingConsidered;
	public TArray<FConversationNodeHandle> ReturnScopeStack;
	public bool bServer;
}
