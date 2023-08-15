namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_SetTransform.h")]
public partial class UIKRig_SetTransform : UIKRigSolver {
	public static UClass StaticClass() {return default;}
	///<summary>Goal</summary>
	public FName Goal;
	///<summary>RootBone</summary>
	public FName RootBone;
	///<summary>Effector</summary>
	public UIKRig_SetTransformEffector Effector;
}
