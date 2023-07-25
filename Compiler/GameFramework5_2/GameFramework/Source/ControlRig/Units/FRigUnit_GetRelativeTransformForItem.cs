#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_GetRelativeTransform.h")]
///<summary>GetRelativeTransform is used to retrieve a single transform from a hierarchy in the space of another transform</summary>
public partial struct FRigUnit_GetRelativeTransformForItem {
// RigUnit_GetRelativeTransformForItem
	public FRigElementKey Child;
	public bool bChildInitial;
	public FRigElementKey Parent;
	public bool bParentInitial;
	public FTransform RelativeTransform;
	public FCachedRigElement CachedChild;
	public FCachedRigElement CachedParent;
}
