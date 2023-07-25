#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationTypes.h")]
public partial struct FClientConversationMessagePayload {
// ClientConversationMessagePayload
	public FClientConversationMessage Message;
	public FConversationParticipants Participants;
	public FConversationNodeHandle CurrentNode;
	public TArray<FClientConversationOptionEntry> Options;
}
