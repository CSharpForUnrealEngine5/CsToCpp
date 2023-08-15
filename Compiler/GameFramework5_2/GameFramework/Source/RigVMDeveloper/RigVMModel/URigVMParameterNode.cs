namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Parameter Node represents an input or output argument / parameter</summary>
[CppInclude("RigVMModel/Nodes/RigVMParameterNode.h")]
public partial class URigVMParameterNode : URigVMNode {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the name of the parameter</summary>
	public FName GetParameterName() { return default; }
	///<summary>Returns true if this node is an input</summary>
	public bool IsInput() { return default; }
	///<summary>Returns the C++ data type of the parameter</summary>
	public string GetCPPType() { return default; }
	///<summary>Returns the C++ data type struct of the parameter (or nullptr)</summary>
	public UObject GetCPPTypeObject() { return default; }
	///<summary>Returns the default value of the parameter as a string</summary>
	public string GetDefaultValue() { return default; }
	///<summary>Returns this parameter node&#39;s parameter description</summary>
	public FRigVMGraphParameterDescription GetParameterDescription() { return default; }
}
