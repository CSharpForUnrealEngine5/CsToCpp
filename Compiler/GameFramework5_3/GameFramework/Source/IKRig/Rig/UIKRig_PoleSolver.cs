namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rig/Solvers/IKRig_PoleSolver.h")]
public partial class UIKRig_PoleSolver : UIKRigSolver {
	public static UClass StaticClass() {return default;}
	///<summary>RootName</summary>
	public FName RootName;
	///<summary>EndName</summary>
	public FName EndName;
	///<summary>Effector</summary>
	public UIKRig_PoleSolverEffector Effector;
}
