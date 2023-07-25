#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action to remap a variable inside of a function reference node renaming a node in the graph.</summary>
public partial struct FRigVMSetRemappedVariableAction {
// RigVMSetRemappedVariableAction
	public string NodePath;
	public string InnerVariableName;
	public string OldOuterVariableName;
	public string NewOuterVariableName;
}
