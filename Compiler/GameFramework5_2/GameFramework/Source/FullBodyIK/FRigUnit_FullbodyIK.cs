#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigUnit_FullbodyIK.h")]
///<summary>Based on Jacobian solver at core, this can solve multi chains within a root using multi effectors</summary>
public partial struct FRigUnit_FullbodyIK {
// RigUnit_FullbodyIK
	public FRigElementKey Root;
	public TArray<FFBIKEndEffector> Effectors;
	public TArray<FFBIKConstraintOption> Constraints;
	public FSolverInput SolverProperty;
	public FMotionProcessInput MotionProperty;
	public bool bPropagateToChildren;
	public FFBIKDebugOption DebugOption;
	public FRigUnit_FullbodyIK_WorkData WorkData;
}
