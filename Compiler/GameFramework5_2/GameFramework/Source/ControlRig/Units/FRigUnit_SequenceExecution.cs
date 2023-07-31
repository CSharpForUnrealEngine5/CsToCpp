#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows for a single execution pulse to trigger a series of events in order.</summary>
[CppInclude("Units/Execution/RigUnit_SequenceExecution.h")]
public partial struct FRigUnit_SequenceExecution {
	public FControlRigExecuteContext ExecuteContext;
	public FControlRigExecuteContext A;
	public FControlRigExecuteContext B;
	public FControlRigExecuteContext C;
	public FControlRigExecuteContext D;
}
