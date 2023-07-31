#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the items in the hierarchy pose</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_PoseGetItems {
	public FRigPose Pose;
	public ERigElementType ElementType;
	public FRigElementKeyCollection Items;
}
