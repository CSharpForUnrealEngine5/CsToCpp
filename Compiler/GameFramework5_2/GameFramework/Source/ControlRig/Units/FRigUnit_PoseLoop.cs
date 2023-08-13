namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Given a pose, execute iteratively across all items in the pose</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_PoseLoop {
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
