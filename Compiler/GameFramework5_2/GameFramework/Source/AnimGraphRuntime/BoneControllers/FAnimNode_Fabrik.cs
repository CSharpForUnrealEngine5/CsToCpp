#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Controller which implements the FABRIK IK approximation algorithm -  see http://www.academia.edu/9165835/FABRIK_A_fast_iterative_solver_for_the_Inverse_Kinematics_problem for details</summary>
[CppInclude("BoneControllers/AnimNode_Fabrik.h")]
public partial struct FAnimNode_Fabrik {
	public FTransform EffectorTransform;
	public FBoneSocketTarget EffectorTarget;
	public FBoneReference TipBone;
	public FBoneReference RootBone;
	public float Precision;
	public int MaxIterations;
	public EBoneControlSpace EffectorTransformSpace;
	public EBoneRotationSource EffectorRotationSource;
	public bool bEnableDebugDraw;
	public FBoneReference EffectorTransformBone_DEPRECATED;
}
