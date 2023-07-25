#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMByteCode.h")]
///<summary>The FRigVMByteCode is a container to store a list of instructions with</summary>
public partial struct FRigVMByteCode {
// RigVMByteCode
	public TArray<byte> ByteCode;
	public int NumInstructions;
	public TArray<FRigVMByteCodeEntry> Entries;
	public TArray<FRigVMBranchInfo> BranchInfos;
}
