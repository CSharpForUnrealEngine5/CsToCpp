#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetRelativeTransform.h")]
///<summary>SetRelativeTranslation is used to set a single translation from a hierarchy in the space of another item</summary>
public partial struct FRigUnit_SetRelativeTranslationForItem {
// RigUnit_SetRelativeTranslationForItem
	public FRigElementKey Child;
	public FRigElementKey Parent;
	public bool bParentInitial;
	public FVector Value;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedChild;
	public FCachedRigElement CachedParent;
}
