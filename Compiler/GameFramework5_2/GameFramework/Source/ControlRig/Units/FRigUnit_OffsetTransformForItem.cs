namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Offset Transform is used to add an offset to an existing transform in the hierarchy. The offset is post multiplied.</summary>
[CppInclude("Units/Hierarchy/RigUnit_OffsetTransform.h")]
public partial struct FRigUnit_OffsetTransformForItem {
	public FRigElementKey Item;
	public FTransform OffsetTransform;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedIndex;
}
