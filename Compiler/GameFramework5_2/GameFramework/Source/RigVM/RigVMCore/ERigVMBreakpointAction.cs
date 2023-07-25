#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVM.h")]
///<summary>Possible actions when the VM is halted at a breakpoint</summary>
public enum ERigVMBreakpointAction {
	None=0,
	Resume=1,
	StepOver=2,
	StepInto=3,
	StepOut=4,
	Max=5,
}
