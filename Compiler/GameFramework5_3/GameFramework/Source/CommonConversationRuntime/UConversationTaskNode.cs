namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The ConversationTaskNode is the basis of any task in the conversation graph,</summary>
[CppInclude("ConversationTaskNode.h")]
public partial class UConversationTaskNode : UConversationNodeWithLinks {
	public static UClass StaticClass() {return default;}
	///<summary>Requirements and side effects</summary>
	public TArray<UConversationSubNode> SubNodes;
	///<summary>EDITOR ONLY VISUALS: Does this task internally have requirements?</summary>
	public bool bHasRequirements;
	///<summary>EDITOR ONLY VISUALS: Does this task generate dynamic choices?</summary>
	public bool bHasDynamicChoices;
	///<summary>This setting is designed for requirements that only matter when option is generated</summary>
	public bool bIgnoreRequirementsWhileAdvancingConversations;
	///<summary>GetNodeBodyColor</summary>
	public bool GetNodeBodyColor(FLinearColor BodyColor) { return default; }
	///<summary>IsRequirementSatisfied</summary>
	public EConversationRequirementResult IsRequirementSatisfied(FConversationContext Context) { return default; }
	///<summary>ExecuteTaskNode</summary>
	public FConversationTaskResult ExecuteTaskNode(FConversationContext Context) { return default; }
	///<summary>ExecuteClientEffects</summary>
	public void ExecuteClientEffects(FConversationContext Context) {}
	///<summary>GatherStaticExtraData</summary>
	public void GatherStaticExtraData(FConversationContext Context,TArray<FConversationNodeParameterPair> InOutExtraData) {}
	///<summary>Default color of the node.</summary>
	public FLinearColor DefaultNodeBodyColor;
}
