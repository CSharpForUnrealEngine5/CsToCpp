namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the items in the hierarchy pose</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_PoseGetItemsItemArray {
	public FRigPose Pose;
	public ERigElementType ElementType;
	public TArray<FRigElementKey> Items;
}
