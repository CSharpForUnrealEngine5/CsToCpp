#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to remap a variable inside of a function reference node renaming a node in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetRemappedVariableAction {
	public string NodePath;
	public string InnerVariableName;
	public string OldOuterVariableName;
	public string NewOuterVariableName;
}
