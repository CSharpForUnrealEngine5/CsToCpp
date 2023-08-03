#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Array Node represents one of a series available</summary>
[CppInclude("RigVMModel/Nodes/RigVMArrayNode.h")]
public partial class UDEPRECATED_RigVMArrayNode : URigVMTemplateNode {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the op code of this node</summary>
	public  ERigVMOpCode GetOpCode() { return default; }
	///<summary>Returns the C++ data type of the element</summary>
	public  string GetCPPType() { return default; }
	///<summary>Returns the C++ data type struct of the array (or nullptr)</summary>
	public  UObject GetCPPTypeObject() { return default; }
	///<summary>OpCode</summary>
	public ERigVMOpCode OpCode;
}
