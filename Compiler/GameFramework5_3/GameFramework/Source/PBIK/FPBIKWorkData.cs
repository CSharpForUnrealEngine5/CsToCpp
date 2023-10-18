namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigUnit_PBIK.h")]
public partial struct FPBIKWorkData {
	public bool bNeedsInit;
	public uint HashInitializedWith;
	public TArray<int> BoneSettingToSolverBoneIndex;
	public TArray<int> SolverBoneToElementIndex;
	public FPBIKSolver Solver;
}
