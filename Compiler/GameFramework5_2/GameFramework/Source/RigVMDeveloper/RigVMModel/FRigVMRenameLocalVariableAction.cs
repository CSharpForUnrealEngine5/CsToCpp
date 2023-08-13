namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to rename a local variable.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMRenameLocalVariableAction {
	public string OldVariableName;
	public string NewVariableName;
}
