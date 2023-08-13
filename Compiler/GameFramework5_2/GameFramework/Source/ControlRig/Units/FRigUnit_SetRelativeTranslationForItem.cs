namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetRelativeTranslation is used to set a single translation from a hierarchy in the space of another item</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetRelativeTransform.h")]
public partial struct FRigUnit_SetRelativeTranslationForItem {
	public FRigElementKey Child;
	public FRigElementKey Parent;
	public bool bParentInitial;
	public FVector Value;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedChild;
	public FCachedRigElement CachedParent;
}
