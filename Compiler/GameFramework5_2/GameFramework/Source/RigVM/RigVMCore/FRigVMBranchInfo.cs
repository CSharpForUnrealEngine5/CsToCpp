#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMMemoryStorage.h")]
///<summary>A description of a branch in the VM's bytecode</summary>
public partial struct FRigVMBranchInfo {
// RigVMBranchInfo
	public int Index;
	public string Label;
	public int InstructionIndex;
	public int ArgumentIndex;
	public ushort FirstInstruction;
	public ushort LastInstruction;
}
