#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The FConversationTaskResult encompasses the type of result along with any extra data we need for</summary>
[CppInclude("ConversationContext.h")]
public partial struct FConversationTaskResult {
	public EConversationTaskResultType Type;
	public FAdvanceConversationRequest AdvanceToChoice;
	public FClientConversationMessage Message;
}
