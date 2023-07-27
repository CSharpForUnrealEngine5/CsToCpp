#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeShaderGraphNode.h")]
///<summary>The Shader Ports API manages a set of inputs and outputs attributes.</summary>
public partial class UInterchangeShaderPortsAPI : UObject {
// InterchangeShaderPortsAPI
	public static string MakeInputConnectionKey(string InputName) { return default; }
	public static string MakeInputValueKey(string InputName) { return default; }
	public static string MakeInputName(string InputKey) { return default; }
	public static bool IsAnInput(string AttributeKey) { return default; }
	public static bool HasInput(UInterchangeBaseNode InterchangeNode,string InInputName) { return default; }
	public static void GatherInputs(UInterchangeBaseNode InterchangeNode,TArray<string> OutInputNames) {}
	public static bool ConnectDefaultOuputToInput(UInterchangeBaseNode InterchangeNode,string InputName,string ExpressionUid) { return default; }
	public static bool ConnectOuputToInput(UInterchangeBaseNode InterchangeNode,string InputName,string ExpressionUid,string OutputName) { return default; }
	public static bool GetInputConnection(UInterchangeBaseNode InterchangeNode,string InputName,string OutExpressionUid,string OutputName) { return default; }
}
