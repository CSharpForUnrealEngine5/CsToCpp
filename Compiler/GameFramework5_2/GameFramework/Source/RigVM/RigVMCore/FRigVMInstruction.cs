#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMByteCode.h")]
///<summary>The FRigVMInstruction represents</summary>
public partial struct FRigVMInstruction {
// RigVMInstruction
	public ulong ByteCodeIndex;
	public ERigVMOpCode OpCode;
	public byte OperandAlignment;
}
