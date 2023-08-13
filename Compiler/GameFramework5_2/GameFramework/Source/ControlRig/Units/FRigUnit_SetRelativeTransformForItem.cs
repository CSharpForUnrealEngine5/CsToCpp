namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetRelativeTransform is used to set a single transform from a hierarchy in the space of another item</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetRelativeTransform.h")]
public partial struct FRigUnit_SetRelativeTransformForItem {
	public FRigElementKey Child;
	public FRigElementKey Parent;
	public bool bParentInitial;
	public FTransform Value;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedChild;
	public FCachedRigElement CachedParent;
}
