namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A shader node is a named set of inputs and outputs. It can be connected to other shader nodes and finally to a shader graph input.</summary>
[CppInclude("InterchangeShaderGraphNode.h")]
public partial class UInterchangeShaderNode : UInterchangeBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>GetCustomShaderType</summary>
	public bool GetCustomShaderType(string AttributeValue) { return default; }
	///<summary>Sets which type of shader this nodes represents. Can be arbitrary or one of the predefined shader types.</summary>
	public bool SetCustomShaderType(string AttributeValue) { return default; }
}
