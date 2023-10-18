namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A function call shader node has a named set of inputs and outputs which corresponds to the inputs and outputs of the shader function it instances.</summary>
[CppInclude("InterchangeShaderGraphNode.h")]
public partial class UInterchangeFunctionCallShaderNode : UInterchangeShaderNode {
	public static UClass StaticClass() {return default;}
	///<summary>GetCustomMaterialFunction</summary>
	public bool GetCustomMaterialFunction(string AttributeValue) { return default; }
	///<summary>Sets the unique id of the material function referenced by the function call expression.</summary>
	public bool SetCustomMaterialFunction(string AttributeValue) { return default; }
}
