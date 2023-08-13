namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action renaming a variable in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMRenameVariableAction {
	public string OldVariableName;
	public string NewVariableName;
}
