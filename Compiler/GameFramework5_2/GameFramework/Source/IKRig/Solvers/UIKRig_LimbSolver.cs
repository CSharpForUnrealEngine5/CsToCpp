#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_LimbSolver.h")]
public partial class UIKRig_LimbSolver : UIKRigSolver {
// IKRig_LimbSolver
	public string RootName;
	public float ReachPrecision;
	public byte HingeRotationAxis;
	public int MaxIterations;
	public bool bEnableLimit;
	public float MinRotationAngle;
	public bool bAveragePull;
	public float PullDistribution;
	public float ReachStepAlpha;
	public bool bEnableTwistCorrection;
	public byte EndBoneForwardAxis;
	public UIKRig_LimbEffector Effector;
}
