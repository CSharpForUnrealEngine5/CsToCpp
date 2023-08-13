namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Enum Node represents a constant enum value for use within the graph.</summary>
[CppInclude("RigVMModel/Nodes/RigVMEnumNode.h")]
public partial class URigVMEnumNode : URigVMNode {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the enum itself</summary>
	public UEnum GetEnum() { return default; }
	///<summary>Returns the C++ data type of the parameter</summary>
	public string GetCPPType() { return default; }
	///<summary>Returns the C++ data type struct of the parameter (or nullptr)</summary>
	public UObject GetCPPTypeObject() { return default; }
}
