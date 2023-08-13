namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>You can think of the FConversationBranchPoint as the owner of FClientConversationOptionEntry.</summary>
[CppInclude("ConversationTypes.h")]
public partial struct FConversationBranchPoint {
	public TArray<FConversationNodeHandle> ReturnScopeStack;
	public FClientConversationOptionEntry ClientChoice;
}
