#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetRelativeTransform.h")]
///<summary>SetRelativeRotation is used to set a single rotation from a hierarchy in the space of another item</summary>
public partial struct FRigUnit_SetRelativeRotationForItem {
// RigUnit_SetRelativeRotationForItem
	public FRigElementKey Child;
	public FRigElementKey Parent;
	public bool bParentInitial;
	public FQuat Value;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedChild;
	public FCachedRigElement CachedParent;
}
