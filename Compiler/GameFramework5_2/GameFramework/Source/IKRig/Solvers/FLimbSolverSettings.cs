#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/LimbSolver.h")]
public partial struct FLimbSolverSettings {
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
