#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationTypes.h")]
public partial struct FAdvanceConversationRequest {
	public FConversationChoiceReference Choice;
	public TArray<FConversationNodeParameterPair> UserParameters;
}
