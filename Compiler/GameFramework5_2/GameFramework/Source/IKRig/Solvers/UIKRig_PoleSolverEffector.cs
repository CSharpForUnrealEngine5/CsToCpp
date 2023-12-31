namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_PoleSolver.h")]
public partial class UIKRig_PoleSolverEffector : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GoalName</summary>
	public FName GoalName;
	///<summary>BoneName</summary>
	public FName BoneName;
	///<summary>Blend the effector on/off. Range is 0-1. Default is 1.0.</summary>
	public float Alpha;
}
