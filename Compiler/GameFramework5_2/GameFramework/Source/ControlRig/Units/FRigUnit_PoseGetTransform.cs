namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the hierarchy&#39;s pose transform</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_PoseGetTransform {
	public FRigPose Pose;
	public FRigElementKey Item;
	public ERigVMTransformSpace Space;
	public bool Valid;
	public FTransform Transform;
	public float CurveValue;
	public int CachedPoseElementIndex;
	public int CachedPoseHash;
}
