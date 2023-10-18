namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows for a single execution pulse to trigger a series of events in order.</summary>
[CppInclude("RigVMFunctions/Execution/RigVMFunction_Sequence.h")]
public partial struct FRigVMFunction_Sequence {
	public FRigVMExecuteContext ExecuteContext;
	public FRigVMExecuteContext A;
	public FRigVMExecuteContext B;
}
