#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The conversation option entry is what we send to the client, one entry per choice.</summary>
[CppInclude("ConversationTypes.h")]
public partial struct FClientConversationOptionEntry {
	public string ChoiceText;
	public FGameplayTagContainer ChoiceTags;
	public EConversationChoiceType ChoiceType;
	public FConversationChoiceReference ChoiceReference;
	public TArray<FConversationNodeParameterPair> ExtraData;
}
