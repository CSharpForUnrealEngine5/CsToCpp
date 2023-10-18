namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The conversation choice reference is the closest thing there is to a link at runtime for a choice.</summary>
[CppInclude("ConversationTypes.h")]
public partial struct FConversationChoiceReference {
	public FConversationNodeHandle NodeReference;
	public TArray<FConversationNodeParameterPair> NodeParameters;
}
