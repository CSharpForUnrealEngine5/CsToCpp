namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sets the hierarchy&#39;s pose</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_HierarchySetPose {
	public FRigPose Pose;
	public ERigElementType ElementType;
	public ERigVMTransformSpace Space;
	public FRigElementKeyCollection ItemsToSet;
	public float Weight;
}
