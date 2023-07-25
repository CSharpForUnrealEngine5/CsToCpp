#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationTypes.h")]
///<summary>You can think of the FConversationBranchPoint as the owner of FClientConversationOptionEntry.</summary>
public partial struct FConversationBranchPoint {
// ConversationBranchPoint
	public TArray<FConversationNodeHandle> ReturnScopeStack;
	public FClientConversationOptionEntry ClientChoice;
}
