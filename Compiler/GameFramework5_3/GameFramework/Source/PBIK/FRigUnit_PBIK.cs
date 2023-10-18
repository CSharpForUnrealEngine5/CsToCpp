namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Based on a Position Based solver at core, this node can solve multi chains within a root using multi effectors</summary>
[CppInclude("RigUnit_PBIK.h")]
public partial struct FRigUnit_PBIK {
	public FName Root;
	public TArray<FPBIKEffector> Effectors;
	public TArray<int> EffectorSolverIndices;
	public TArray<FPBIKBoneSetting> BoneSettings;
	public TArray<FName> ExcludedBones;
	public FPBIKSolverSettings Settings;
	public FPBIKDebug Debug;
	public FPBIKWorkData WorkData;
}
