#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a single runtime node in the conversation database.</summary>
[CppInclude("ConversationNode.h")]
public partial class UConversationNode : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetDebugParticipantColor</summary>
	public  FLinearColor GetDebugParticipantColor(FGameplayTag ParticipantID) { return default; }
	///<summary>EvalWorldContextObj</summary>
	public UObject EvalWorldContextObj;
	///<summary>node name</summary>
	public string NodeName;
	///<summary>The node&#39;s unique ID.  This value is set during compilation.</summary>
	public FGuid Compiled_NodeGUID;
	///<summary>show detailed information about properties</summary>
	public bool bShowPropertyDetails;
	///<summary>show detailed information about properties</summary>
	public bool bShowPropertyEditors;
	///<summary>parent node</summary>
	public UConversationNode ParentNode;
}
