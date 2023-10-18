namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The execute context is used for mutable nodes to</summary>
[CppInclude("RigVMCore/RigVMExecuteContext.h")]
public partial struct FRigVMExtendedExecuteContext {
	public uint VMHash;
	public uint NumExecutions;
	public URigVM DeferredVMToCopy;
}
