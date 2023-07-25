#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
///<summary>Given a pose, execute iteratively across all items in the pose</summary>
public partial struct FRigUnit_PoseLoop {
// RigUnit_PoseLoop
	public string BlockToRun;
	public FRigPose Pose;
	public FRigElementKey Item;
	public FTransform GlobalTransform;
	public FTransform LocalTransform;
	public float CurveValue;
	public int Index;
	public int Count;
	public float Ratio;
	public FControlRigExecuteContext Completed;
}
