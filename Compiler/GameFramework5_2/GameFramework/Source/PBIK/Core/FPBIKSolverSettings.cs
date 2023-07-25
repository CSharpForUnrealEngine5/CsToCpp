#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Core/PBIKSolver.h")]
public partial struct FPBIKSolverSettings {
// PBIKSolverSettings
	public int Iterations;
	public float MassMultiplier;
	public bool bAllowStretch;
	public EPBIKRootBehavior RootBehavior;
	public FRootPrePullSettings PrePullRootSettings;
	public float GlobalPullChainAlpha;
	public float MaxAngle;
	public float OverRelaxation;
	public bool bStartSolveFromInputPose;
}
