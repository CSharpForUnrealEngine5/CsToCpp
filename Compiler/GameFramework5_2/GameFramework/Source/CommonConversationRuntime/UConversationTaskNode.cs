#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationTaskNode.h")]
///<summary>The ConversationTaskNode is the basis of any task in the conversation graph,</summary>
public partial class UConversationTaskNode : UConversationNodeWithLinks {
// ConversationTaskNode
	public TArray<UConversationSubNode> SubNodes;
	public bool bHasRequirements;
	public bool bHasDynamicChoices;
	public bool bIgnoreRequirementsWhileAdvancingConversations;
	public  bool GetNodeBodyColor(FLinearColor BodyColor) { return default; }
	public  EConversationRequirementResult IsRequirementSatisfied(FConversationContext Context) { return default; }
	public  FConversationTaskResult ExecuteTaskNode(FConversationContext Context) { return default; }
	public  void ExecuteClientEffects(FConversationContext Context) {}
	public  void GatherStaticExtraData(FConversationContext Context,TArray<FConversationNodeParameterPair> InOutExtraData) {}
	public FLinearColor DefaultNodeBodyColor;
}
