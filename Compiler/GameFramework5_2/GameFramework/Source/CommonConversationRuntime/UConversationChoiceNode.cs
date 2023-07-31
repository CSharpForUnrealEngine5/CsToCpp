#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A choice on a task indicates that an option be presented to the user when the owning task is one of</summary>
[CppInclude("ConversationChoiceNode.h")]
public partial class UConversationChoiceNode : UConversationSubNode {
	///<summary>DefaultChoiceDisplayText</summary>
	public string DefaultChoiceDisplayText;
	///<summary>ChoiceTags</summary>
	public FGameplayTagContainer ChoiceTags;
	///<summary>FillChoice</summary>
	public  void FillChoice(FConversationContext Context,FClientConversationOptionEntry ChoiceEntry) {}
}
