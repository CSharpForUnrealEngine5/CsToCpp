namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_SetTransform.h")]
public partial class UIKRig_SetTransform : UIKRigSolver {
	public static UClass StaticClass() {return default;}
	///<summary>Goal</summary>
	public string Goal;
	///<summary>RootBone</summary>
	public string RootBone;
	///<summary>Effector</summary>
	public UIKRig_SetTransformEffector Effector;
}
