namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_PoleSolver.h")]
public partial class UIKRig_PoleSolver : UIKRigSolver {
	public static UClass StaticClass() {return default;}
	///<summary>RootName</summary>
	public string RootName;
	///<summary>EndName</summary>
	public string EndName;
	///<summary>Effector</summary>
	public UIKRig_PoleSolverEffector Effector;
}
