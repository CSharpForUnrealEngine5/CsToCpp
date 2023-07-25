#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_FBIKSolver.h")]
public partial class UIKRigFBIKSolver : UIKRigSolver {
// IKRigFBIKSolver
	public string RootBone;
	public int Iterations;
	public float MassMultiplier;
	public bool bAllowStretch;
	public EPBIKRootBehavior RootBehavior;
	public FRootPrePullSettings PrePullRootSettings;
	public float PullChainAlpha;
	public float MaxAngle;
	public float OverRelaxation;
	public bool bStartSolveFromInputPose;
	public TArray<UIKRig_FBIKEffector> Effectors;
	public TArray<UIKRig_FBIKBoneSettings> BoneSettings;
}
