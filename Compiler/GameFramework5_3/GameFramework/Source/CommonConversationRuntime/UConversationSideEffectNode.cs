namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Side effects are actions that are performed just after a task is executed</summary>
[CppInclude("ConversationSideEffectNode.h")]
public partial class UConversationSideEffectNode : UConversationSubNode {
	public static UClass StaticClass() {return default;}
	///<summary>ServerCauseSideEffect</summary>
	public void ServerCauseSideEffect(FConversationContext Context) {}
	///<summary>ClientCauseSideEffect</summary>
	public void ClientCauseSideEffect(FConversationContext Context) {}
}
