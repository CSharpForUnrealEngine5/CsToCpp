#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
///<summary>Returns the hierarchy's pose</summary>
public partial struct FRigUnit_HierarchyGetPose {
// RigUnit_HierarchyGetPose
	public bool Initial;
	public ERigElementType ElementType;
	public FRigElementKeyCollection ItemsToGet;
	public FRigPose Pose;
}
