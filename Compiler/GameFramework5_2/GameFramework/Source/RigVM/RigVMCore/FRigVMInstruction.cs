#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The FRigVMInstruction represents</summary>
[CppInclude("RigVMCore/RigVMByteCode.h")]
public partial struct FRigVMInstruction {
	public ulong ByteCodeIndex;
	public ERigVMOpCode OpCode;
	public byte OperandAlignment;
}
