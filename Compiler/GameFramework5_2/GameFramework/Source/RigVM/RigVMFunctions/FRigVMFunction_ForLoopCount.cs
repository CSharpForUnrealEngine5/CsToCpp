namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Given a count, execute iteratively until the count is up</summary>
[CppInclude("RigVMFunctions/Execution/RigVMFunction_ForLoop.h")]
public partial struct FRigVMFunction_ForLoopCount {
	public string BlockToRun;
	public int Count;
	public int Index;
	public float Ratio;
	public FRigVMExecuteContext Completed;
}
