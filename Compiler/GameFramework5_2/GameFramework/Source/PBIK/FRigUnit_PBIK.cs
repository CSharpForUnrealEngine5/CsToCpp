#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigUnit_PBIK.h")]
///<summary>* Based on a Position Based solver at core, this node can solve multi chains within a root using multi effectors</summary>
public partial struct FRigUnit_PBIK {
// RigUnit_PBIK
	public string Root;
	public TArray<FPBIKEffector> Effectors;
	public TArray<int> EffectorSolverIndices;
	public TArray<FPBIKBoneSetting> BoneSettings;
	public TArray<string> ExcludedBones;
	public FPBIKSolverSettings Settings;
	public FPBIKDebug Debug;
	public TArray<int> BoneSettingToSolverBoneIndex;
	public TArray<int> SolverBoneToElementIndex;
	public FPBIKSolver Solver;
	public bool bNeedsInit;
}
