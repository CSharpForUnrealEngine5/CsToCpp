#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_SetTransform.h")]
public partial class UIKRig_SetTransform : UIKRigSolver {
	///<summary>Goal</summary>
	public string Goal;
	///<summary>RootBone</summary>
	public string RootBone;
	///<summary>Effector</summary>
	public UIKRig_SetTransformEffector Effector;
}
