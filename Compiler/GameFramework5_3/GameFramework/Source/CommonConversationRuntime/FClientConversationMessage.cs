namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationTypes.h")]
public partial struct FClientConversationMessage {
	public FGameplayTag SpeakerID;
	public FText ParticipantDisplayName;
	public FText Text;
	public TArray<FConversationNodeParameterPair> MetadataParameters;
}
