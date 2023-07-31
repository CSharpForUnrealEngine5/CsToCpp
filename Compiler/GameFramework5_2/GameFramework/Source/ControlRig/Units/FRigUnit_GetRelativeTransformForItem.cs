#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetRelativeTransform is used to retrieve a single transform from a hierarchy in the space of another transform</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetRelativeTransform.h")]
public partial struct FRigUnit_GetRelativeTransformForItem {
	public FRigElementKey Child;
	public bool bChildInitial;
	public FRigElementKey Parent;
	public bool bParentInitial;
	public FTransform RelativeTransform;
	public FCachedRigElement CachedChild;
	public FCachedRigElement CachedParent;
}
