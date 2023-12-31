namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sets the hierarchy&#39;s pose</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_HierarchySetPoseItemArray {
	public FRigPose Pose;
	public ERigElementType ElementType;
	public ERigVMTransformSpace Space;
	public TArray<FRigElementKey> ItemsToSet;
	public float Weight;
}
