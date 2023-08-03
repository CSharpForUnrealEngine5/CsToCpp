#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Shader Ports API manages a set of inputs and outputs attributes.</summary>
[CppInclude("InterchangeShaderGraphNode.h")]
public partial class UInterchangeShaderPortsAPI : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Makes an attribute key to represent a node being connected to an input (ie: Inputs:InputName:Connect).</summary>
	public static string MakeInputConnectionKey(string InputName) { return default; }
	///<summary>Makes an attribute key to represent a value being given to an input (ie: Inputs:InputName:Value).</summary>
	public static string MakeInputValueKey(string InputName) { return default; }
	///<summary>From an attribute key associated with an input (ie: Inputs:InputName:Value), retrieves the input name from it.</summary>
	public static string MakeInputName(string InputKey) { return default; }
	///<summary>Returns true if the attribute key is associated with an input (starts with &quot;Inputs:&quot;).</summary>
	public static bool IsAnInput(string AttributeKey) { return default; }
	///<summary>Checks if a particular input exists on a given node.</summary>
	public static bool HasInput(UInterchangeBaseNode InterchangeNode,string InInputName) { return default; }
	///<summary>Retrieves the names of all the inputs for a given node.</summary>
	public static void GatherInputs(UInterchangeBaseNode InterchangeNode,TArray<string> OutInputNames) {}
	///<summary>Adds an input connection attribute.</summary>
	public static bool ConnectDefaultOuputToInput(UInterchangeBaseNode InterchangeNode,string InputName,string ExpressionUid) { return default; }
	///<summary>Adds an input connection attribute.</summary>
	public static bool ConnectOuputToInput(UInterchangeBaseNode InterchangeNode,string InputName,string ExpressionUid,string OutputName) { return default; }
	///<summary>Retrieves the node unique id and the ouputname connected to a given input, if any.</summary>
	public static bool GetInputConnection(UInterchangeBaseNode InterchangeNode,string InputName,string OutExpressionUid,string OutputName) { return default; }
}
