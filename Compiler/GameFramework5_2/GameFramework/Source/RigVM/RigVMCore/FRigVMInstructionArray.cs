namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The FRigVMInstructionArray represents all current instructions</summary>
[CppInclude("RigVMCore/RigVMByteCode.h")]
public partial struct FRigVMInstructionArray {
	public TArray<FRigVMInstruction> Instructions;
}
