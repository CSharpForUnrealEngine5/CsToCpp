namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_FBIKSolver.h")]
public partial class UIKRig_FBIKEffector : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The Goal that is driving this effector&#39;s transform.</summary>
	public FName GoalName;
	///<summary>The bone that this effector will pull on.</summary>
	public FName BoneName;
	///<summary>Range 0-1 (default is 1.0). The strength of the effector when pulling the bone towards it&#39;s target location.</summary>
	public float StrengthAlpha;
	///<summary>Range 0-1 (default is 1.0). When enabled (greater than 0.0), the solver internally partitions the skeleton into &#39;chains&#39; which extend from the effector to the nearest fork in the skeleton.</summary>
	public float PullChainAlpha;
	///<summary>Range 0-1 (default is 1.0).</summary>
	public float PinRotation;
	///<summary>IndexInSolver</summary>
	public int IndexInSolver;
}
