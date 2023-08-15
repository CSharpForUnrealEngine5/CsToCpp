namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_LimbSolver.h")]
public partial class UIKRig_LimbSolver : UIKRigSolver {
	public static UClass StaticClass() {return default;}
	///<summary>RootName</summary>
	public FName RootName;
	///<summary>Precision (distance to the target)</summary>
	public float ReachPrecision;
	///<summary>Hinge Bones Rotation Axis. This is essentially the plane normal for (hip - knee - foot).</summary>
	public EAxis HingeRotationAxis;
	///<summary>Number of Max Iterations to reach the target</summary>
	public int MaxIterations;
	///<summary>Enable/Disable rotational limits</summary>
	public bool bEnableLimit;
	///<summary>Only used if bEnableRotationLimit is enabled. Prevents the leg from folding onto itself,</summary>
	public float MinRotationAngle;
	///<summary>Pull averaging only has a visual impact when we have more than 2 bones (3 links).</summary>
	public bool bAveragePull;
	///<summary>Re-position limb to distribute pull: 0 = foot, 0.5 = balanced, 1.f = hip</summary>
	public float PullDistribution;
	///<summary>Move end effector towards target. If we are compressing the chain, limit displacement.</summary>
	public float ReachStepAlpha;
	///<summary>Enable Knee Twist correction, by comparing Foot FK with Foot IK orientation.</summary>
	public bool bEnableTwistCorrection;
	///<summary>Forward Axis for Foot bone.</summary>
	public EAxis EndBoneForwardAxis;
	///<summary>Effector</summary>
	public UIKRig_LimbEffector Effector;
}
