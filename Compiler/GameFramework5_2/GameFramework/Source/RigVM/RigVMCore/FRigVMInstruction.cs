namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The FRigVMInstruction represents</summary>
[CppInclude("RigVMCore/RigVMByteCode.h")]
public partial struct FRigVMInstruction {
	public ulong ByteCodeIndex;
	public ERigVMOpCode OpCode;
	public byte OperandAlignment;
}
