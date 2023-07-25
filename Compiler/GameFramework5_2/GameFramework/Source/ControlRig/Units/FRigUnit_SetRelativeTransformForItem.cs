#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetRelativeTransform.h")]
///<summary>SetRelativeTransform is used to set a single transform from a hierarchy in the space of another item</summary>
public partial struct FRigUnit_SetRelativeTransformForItem {
// RigUnit_SetRelativeTransformForItem
	public FRigElementKey Child;
	public FRigElementKey Parent;
	public bool bParentInitial;
	public FTransform Value;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedChild;
	public FCachedRigElement CachedParent;
}
