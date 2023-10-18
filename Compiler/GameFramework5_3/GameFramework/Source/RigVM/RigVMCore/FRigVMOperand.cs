namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The FRigVMOperand represents an argument used for an operator</summary>
[CppInclude("RigVMCore/RigVMMemoryCommon.h")]
public partial struct FRigVMOperand {
	public ERigVMMemoryType MemoryType;
	public ushort RegisterIndex;
	public ushort RegisterOffset;
}
