namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetRelativeRotation is used to set a single rotation from a hierarchy in the space of another item</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetRelativeTransform.h")]
public partial struct FRigUnit_SetRelativeRotationForItem {
	public FRigElementKey Child;
	public FRigElementKey Parent;
	public bool bParentInitial;
	public FQuat Value;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedChild;
	public FCachedRigElement CachedParent;
}
