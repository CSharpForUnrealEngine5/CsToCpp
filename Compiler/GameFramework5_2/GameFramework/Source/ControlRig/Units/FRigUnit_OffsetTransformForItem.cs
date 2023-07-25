#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_OffsetTransform.h")]
///<summary>Offset Transform is used to add an offset to an existing transform in the hierarchy. The offset is post multiplied.</summary>
public partial struct FRigUnit_OffsetTransformForItem {
// RigUnit_OffsetTransformForItem
	public FRigElementKey Item;
	public FTransform OffsetTransform;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedIndex;
}
