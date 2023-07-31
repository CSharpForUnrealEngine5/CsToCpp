#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A requirement is placed on a parent node to control whether or not it can be activated</summary>
[CppInclude("ConversationRequirementNode.h")]
public partial class UConversationRequirementNode : UConversationSubNode {
	///<summary>IsRequirementSatisfied</summary>
	public  EConversationRequirementResult IsRequirementSatisfied(FConversationContext Context) { return default; }
}
