#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The FRigVMByteCode is a container to store a list of instructions with</summary>
[CppInclude("RigVMCore/RigVMByteCode.h")]
public partial struct FRigVMByteCode {
	public TArray<byte> ByteCode;
	public int NumInstructions;
	public TArray<FRigVMByteCodeEntry> Entries;
	public TArray<FRigVMBranchInfo> BranchInfos;
}
