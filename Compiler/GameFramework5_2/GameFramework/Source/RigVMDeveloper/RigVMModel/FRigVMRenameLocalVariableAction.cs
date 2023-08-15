namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to rename a local variable.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMRenameLocalVariableAction {
	public FName OldVariableName;
	public FName NewVariableName;
}
