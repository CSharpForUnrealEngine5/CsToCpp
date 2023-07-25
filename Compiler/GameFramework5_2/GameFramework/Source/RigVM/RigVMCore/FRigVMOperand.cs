#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMMemoryCommon.h")]
///<summary>The FRigVMOperand represents an argument used for an operator</summary>
public partial struct FRigVMOperand {
// RigVMOperand
	public ERigVMMemoryType MemoryType;
	public ushort RegisterIndex;
	public ushort RegisterOffset;
}
