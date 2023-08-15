namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to remap a variable inside of a function reference node renaming a node in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetRemappedVariableAction {
	public string NodePath;
	public FName InnerVariableName;
	public FName OldOuterVariableName;
	public FName NewOuterVariableName;
}
