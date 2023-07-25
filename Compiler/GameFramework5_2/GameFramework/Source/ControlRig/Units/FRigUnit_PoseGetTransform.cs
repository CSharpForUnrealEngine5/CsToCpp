#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
///<summary>Returns the hierarchy's pose transform</summary>
public partial struct FRigUnit_PoseGetTransform {
// RigUnit_PoseGetTransform
	public FRigPose Pose;
	public FRigElementKey Item;
	public ERigVMTransformSpace Space;
	public bool Valid;
	public FTransform Transform;
	public float CurveValue;
	public int CachedPoseElementIndex;
	public int CachedPoseHash;
}
