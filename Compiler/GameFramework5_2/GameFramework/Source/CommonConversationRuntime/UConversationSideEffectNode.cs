#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Side effects are actions that are performed just after a task is executed</summary>
[CppInclude("ConversationSideEffectNode.h")]
public partial class UConversationSideEffectNode : UConversationSubNode {
	///<summary>ServerCauseSideEffect</summary>
	public  void ServerCauseSideEffect(FConversationContext Context) {}
	///<summary>ClientCauseSideEffect</summary>
	public  void ClientCauseSideEffect(FConversationContext Context) {}
}
