#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_FBIKSolver.h")]
public partial class UIKRigFBIKSolver : UIKRigSolver {
	public static UClass StaticClass() {return default;}
	///<summary>All bones above this bone in the hierarchy will be completely ignored by the solver. Typically this is set to</summary>
	public string RootBone;
	///<summary>High iteration counts can help solve complex joint configurations with competing constraints, but will increase runtime cost. Default is 20.</summary>
	public int Iterations;
	///<summary>A global mass multiplier; higher values will make the joints more stiff, but require more iterations. Typical range is 0.0 to 10.0.</summary>
	public float MassMultiplier;
	///<summary>If true, joints will translate to reach the effectors; causing bones to lengthen if necessary. Good for cartoon effects. Default is false.</summary>
	public bool bAllowStretch;
	///<summary>(Default is PrePull) Set the behavior of the solver root.</summary>
	public EPBIKRootBehavior RootBehavior;
	///<summary>Settings only applicable when Root Behavior is set to &quot;PrePull&quot;. Use these values to adjust the gross movement and orientation of the entire skeleton.</summary>
	public FRootPrePullSettings PrePullRootSettings;
	///<summary>A global multiplier for all Pull Chain Alpha values on all effectors. Range is 0.0 to 1.0. Default is 1.0.</summary>
	public float PullChainAlpha;
	///<summary>Maximum angle that a joint can be rotated per constraint iteration. Lower this value if the solve is diverging. Range is 0.0 to 180.0. Default is 30.</summary>
	public float MaxAngle;
	///<summary>Pushes constraints beyond their normal amount to speed up convergence. Increasing this may speed up convergence, but at the cost of stability. Range is 1.0 - 2.0. Default is 1.3.</summary>
	public float OverRelaxation;
	///<summary>When true, the solver is reset each tick to start from the current input pose. Default is true.</summary>
	public bool bStartSolveFromInputPose;
	///<summary>Effectors</summary>
	public TArray<UIKRig_FBIKEffector> Effectors;
	///<summary>BoneSettings</summary>
	public TArray<UIKRig_FBIKBoneSettings> BoneSettings;
}
