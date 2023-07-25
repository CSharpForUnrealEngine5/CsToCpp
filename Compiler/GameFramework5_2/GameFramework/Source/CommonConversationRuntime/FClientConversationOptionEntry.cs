#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationTypes.h")]
///<summary>The conversation option entry is what we send to the client, one entry per choice.</summary>
public partial struct FClientConversationOptionEntry {
// ClientConversationOptionEntry
	public string ChoiceText;
	public FGameplayTagContainer ChoiceTags;
	public EConversationChoiceType ChoiceType;
	public FConversationChoiceReference ChoiceReference;
	public TArray<FConversationNodeParameterPair> ExtraData;
}
