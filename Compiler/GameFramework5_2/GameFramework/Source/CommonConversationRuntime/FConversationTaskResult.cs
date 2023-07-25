#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationContext.h")]
///<summary>The FConversationTaskResult encompasses the type of result along with any extra data we need for</summary>
public partial struct FConversationTaskResult {
// ConversationTaskResult
	public EConversationTaskResultType Type;
	public FAdvanceConversationRequest AdvanceToChoice;
	public FClientConversationMessage Message;
}
