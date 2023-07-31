#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_Tunnel.h")]
public partial class UK2Node_Tunnel : UK2Node_EditablePinBase {
	///<summary>The output pins of this tunnel node came from the input pins of OutputSourceNode</summary>
	public UK2Node_Tunnel OutputSourceNode;
	///<summary>The input pins of this tunnel go to the output pins of InputSinkNode</summary>
	public UK2Node_Tunnel InputSinkNode;
	///<summary>Whether this node is allowed to have inputs</summary>
	public bool bCanHaveInputs;
	///<summary>Whether this node is allowed to have outputs</summary>
	public bool bCanHaveOutputs;
	///<summary>The metadata for the function/subgraph associated with this tunnel node; it&#39;s only editable and used</summary>
	public FKismetUserDeclaredFunctionMetadata MetaData;
}
