#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The FRigVMOperand represents an argument used for an operator</summary>
[CppInclude("RigVMCore/RigVMMemoryCommon.h")]
public partial struct FRigVMOperand {
	public ERigVMMemoryType MemoryType;
	public ushort RegisterIndex;
	public ushort RegisterOffset;
}
