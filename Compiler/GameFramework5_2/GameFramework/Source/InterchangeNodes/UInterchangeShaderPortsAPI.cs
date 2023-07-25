#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeShaderGraphNode.h")]
///<summary>The Shader Ports API manages a set of inputs and outputs attributes.</summary>
public partial class UInterchangeShaderPortsAPI : UObject {
// InterchangeShaderPortsAPI
	public string MakeInputConnectionKey(string InputName) { return default; }
	public string MakeInputValueKey(string InputName) { return default; }
	public string MakeInputName(string InputKey) { return default; }
	public bool IsAnInput(string AttributeKey) { return default; }
	public bool HasInput(UObject InterchangeNode,string InInputName) { return default; }
	public void GatherInputs(UObject InterchangeNode,TArray<string> OutInputNames) {}
	public bool ConnectDefaultOuputToInput(UObject InterchangeNode,string InputName,string ExpressionUid) { return default; }
	public bool ConnectOuputToInput(UObject InterchangeNode,string InputName,string ExpressionUid,string OutputName) { return default; }
	public bool GetInputConnection(UObject InterchangeNode,string InputName,string OutExpressionUid,string OutputName) { return default; }
}
