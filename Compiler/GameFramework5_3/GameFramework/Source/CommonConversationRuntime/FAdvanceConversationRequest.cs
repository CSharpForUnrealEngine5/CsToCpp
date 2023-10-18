namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationTypes.h")]
public partial struct FAdvanceConversationRequest {
	public FConversationChoiceReference Choice;
	public TArray<FConversationNodeParameterPair> UserParameters;
}
