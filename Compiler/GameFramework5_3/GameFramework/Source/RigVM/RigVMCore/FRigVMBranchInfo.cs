namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A description of a branch in the VM&#39;s bytecode</summary>
[CppInclude("RigVMCore/RigVMMemoryStorage.h")]
public partial struct FRigVMBranchInfo {
	public int Index;
	public FName Label;
	public int InstructionIndex;
	public int ArgumentIndex;
	public ushort FirstInstruction;
	public ushort LastInstruction;
}
