namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationTypes.h")]
public partial struct FClientConversationMessagePayload {
	public FClientConversationMessage Message;
	public FConversationParticipants Participants;
	public FConversationNodeHandle CurrentNode;
	public TArray<FClientConversationOptionEntry> Options;
}
