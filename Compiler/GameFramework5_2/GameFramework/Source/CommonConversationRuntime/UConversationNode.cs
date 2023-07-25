#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationNode.h")]
///<summary>Represents a single runtime node in the conversation database.</summary>
public partial class UConversationNode : UObject {
// ConversationNode
	public FLinearColor GetDebugParticipantColor(FGameplayTag ParticipantID) { return default; }
	public UObject EvalWorldContextObj;
	public string NodeName;
	public FGuid Compiled_NodeGUID;
	public bool bShowPropertyDetails;
	public bool bShowPropertyEditors;
	public UConversationNode ParentNode;
}
