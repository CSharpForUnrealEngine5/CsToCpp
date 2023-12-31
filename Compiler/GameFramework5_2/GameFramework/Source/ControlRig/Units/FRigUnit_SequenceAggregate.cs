namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows for a single execution pulse to trigger a series of events in order.</summary>
[CppInclude("Units/Execution/RigUnit_SequenceExecution.h")]
public partial struct FRigUnit_SequenceAggregate {
	public FControlRigExecuteContext ExecuteContext;
	public FControlRigExecuteContext A;
	public FControlRigExecuteContext B;
}
