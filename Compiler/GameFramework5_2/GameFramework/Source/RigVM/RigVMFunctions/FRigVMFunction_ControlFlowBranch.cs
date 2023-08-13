namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Executes either the True or False branch based on the condition</summary>
[CppInclude("RigVMFunctions/RigVMFunction_ControlFlow.h")]
public partial struct FRigVMFunction_ControlFlowBranch {
	public FRigVMExecuteContext ExecuteContext;
	public bool Condition;
	public FRigVMExecuteContext True;
	public FRigVMExecuteContext False;
	public FRigVMExecuteContext Completed;
	public string BlockToRun;
}
