#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>User Defined Event for running custom logic</summary>
[CppInclude("RigVMFunctions/Execution/RigVMFunction_UserDefinedEvent.h")]
public partial struct FRigVMFunction_UserDefinedEvent {
	public FRigVMExecuteContext ExecuteContext;
	public string EventName;
}
