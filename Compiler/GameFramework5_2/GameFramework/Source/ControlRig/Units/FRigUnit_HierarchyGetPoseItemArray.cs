#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the hierarchy&#39;s pose</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_HierarchyGetPoseItemArray {
	public bool Initial;
	public ERigElementType ElementType;
	public TArray<FRigElementKey> ItemsToGet;
	public FRigPose Pose;
}
