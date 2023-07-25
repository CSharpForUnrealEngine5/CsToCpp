#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationChoiceNode.h")]
///<summary>A choice on a task indicates that an option be presented to the user when the owning task is one of</summary>
public partial class UConversationChoiceNode : UConversationSubNode {
// ConversationChoiceNode
	public string DefaultChoiceDisplayText;
	public FGameplayTagContainer ChoiceTags;
	public void FillChoice(FConversationContext Context,FClientConversationOptionEntry ChoiceEntry) {}
}
