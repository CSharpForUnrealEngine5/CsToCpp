namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A choice on a task indicates that an option be presented to the user when the owning task is one of</summary>
[CppInclude("ConversationChoiceNode.h")]
public partial class UConversationChoiceNode : UConversationSubNode {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultChoiceDisplayText</summary>
	public FText DefaultChoiceDisplayText;
	///<summary>ChoiceTags</summary>
	public FGameplayTagContainer ChoiceTags;
	///<summary>FillChoice</summary>
	public void FillChoice(FConversationContext Context,FClientConversationOptionEntry ChoiceEntry) {}
}
