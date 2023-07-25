#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/Nodes/RigVMVariableNode.h")]
///<summary>The Variable Node represents a mutable value / local state within the</summary>
public partial class URigVMVariableNode : URigVMNode {
// RigVMVariableNode
	public string GetVariableName() { return default; }
	public bool IsGetter() { return default; }
	public bool IsExternalVariable() { return default; }
	public bool IsLocalVariable() { return default; }
	public bool IsInputArgument() { return default; }
	public string GetCPPType() { return default; }
	public UObject GetCPPTypeObject() { return default; }
	public string GetDefaultValue() { return default; }
	public FRigVMGraphVariableDescription GetVariableDescription() { return default; }
}
