#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/LimbSolver.h")]
public partial struct FLimbSolverSettings {
// LimbSolverSettings
	public float ReachPrecision;
	public EAxis HingeRotationAxis;
	public int MaxIterations;
	public bool bEnableLimit;
	public float MinRotationAngle;
	public bool bAveragePull;
	public float PullDistribution;
	public float ReachStepAlpha;
	public bool bEnableTwistCorrection;
	public EAxis EndBoneForwardAxis;
}
