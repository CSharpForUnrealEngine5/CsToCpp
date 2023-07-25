#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationTypes.h")]
public partial struct FAdvanceConversationRequest {
// AdvanceConversationRequest
	public FConversationChoiceReference Choice;
	public TArray<FConversationNodeParameterPair> UserParameters;
}
