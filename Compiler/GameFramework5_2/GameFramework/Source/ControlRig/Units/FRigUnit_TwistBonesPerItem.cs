#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TwistBones.h")]
///<summary>Creates a gradient of twist rotation along a collection of items.</summary>
public partial struct FRigUnit_TwistBonesPerItem {
// RigUnit_TwistBonesPerItem
	public FRigElementKeyCollection Items;
	public FVector TwistAxis;
	public FVector PoleAxis;
	public ERigVMAnimEasingType TwistEaseType;
	public float Weight;
	public bool bPropagateToChildren;
	public FRigUnit_TwistBones_WorkData WorkData;
}
