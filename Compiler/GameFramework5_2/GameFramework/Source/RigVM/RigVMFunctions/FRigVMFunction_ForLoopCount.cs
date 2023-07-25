#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Execution/RigVMFunction_ForLoop.h")]
///<summary>Given a count, execute iteratively until the count is up</summary>
public partial struct FRigVMFunction_ForLoopCount {
// RigVMFunction_ForLoopCount
	public string BlockToRun;
	public int Count;
	public int Index;
	public float Ratio;
	public FRigVMExecuteContext Completed;
}
