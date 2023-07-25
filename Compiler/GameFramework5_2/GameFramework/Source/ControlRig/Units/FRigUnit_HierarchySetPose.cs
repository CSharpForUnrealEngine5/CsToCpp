#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
///<summary>Sets the hierarchy's pose</summary>
public partial struct FRigUnit_HierarchySetPose {
// RigUnit_HierarchySetPose
	public FRigPose Pose;
	public ERigElementType ElementType;
	public ERigVMTransformSpace Space;
	public FRigElementKeyCollection ItemsToSet;
	public float Weight;
}
