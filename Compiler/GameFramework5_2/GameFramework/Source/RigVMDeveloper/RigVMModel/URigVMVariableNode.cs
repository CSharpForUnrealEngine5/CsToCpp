namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Variable Node represents a mutable value / local state within the</summary>
[CppInclude("RigVMModel/Nodes/RigVMVariableNode.h")]
public partial class URigVMVariableNode : URigVMNode {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the name of the variable</summary>
	public string GetVariableName() { return default; }
	///<summary>Returns true if this node is a variable getter</summary>
	public bool IsGetter() { return default; }
	///<summary>Returns true if this variable is an external variable</summary>
	public bool IsExternalVariable() { return default; }
	///<summary>Returns true if this variable is a local variable</summary>
	public bool IsLocalVariable() { return default; }
	///<summary>Returns true if this variable is an input argument</summary>
	public bool IsInputArgument() { return default; }
	///<summary>Returns the C++ data type of the variable</summary>
	public string GetCPPType() { return default; }
	///<summary>Returns the C++ data type struct of the variable (or nullptr)</summary>
	public UObject GetCPPTypeObject() { return default; }
	///<summary>Returns the default value of the variable as a string</summary>
	public string GetDefaultValue() { return default; }
	///<summary>Returns this variable node&#39;s variable description</summary>
	public FRigVMGraphVariableDescription GetVariableDescription() { return default; }
}
