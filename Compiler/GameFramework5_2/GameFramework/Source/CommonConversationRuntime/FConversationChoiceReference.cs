#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationTypes.h")]
///<summary>The conversation choice reference is the closest thing there is to a link at runtime for a choice.</summary>
public partial struct FConversationChoiceReference {
// ConversationChoiceReference
	public FConversationNodeHandle NodeReference;
	public TArray<FConversationNodeParameterPair> NodeParameters;
}
