#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/RigVMFunction_ControlFlow.h")]
///<summary>Executes either the True or False branch based on the condition</summary>
public partial struct FRigVMFunction_ControlFlowBranch {
// RigVMFunction_ControlFlowBranch
	public FRigVMExecuteContext ExecuteContext;
	public bool Condition;
	public FRigVMExecuteContext True;
	public FRigVMExecuteContext False;
	public FRigVMExecuteContext Completed;
	public string BlockToRun;
}
