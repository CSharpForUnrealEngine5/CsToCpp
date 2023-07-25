#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TransformConstraint.h")]
///<summary>Constrains an item's position to multiple items' positions</summary>
public partial struct FRigUnit_PositionConstraintLocalSpaceOffset {
// RigUnit_PositionConstraintLocalSpaceOffset
	public FRigElementKey Child;
	public bool bMaintainOffset;
	public FFilterOptionPerAxis Filter;
	public TArray<FConstraintParent> Parents;
	public float Weight;
	public FCachedRigElement ChildCache;
	public TArray<FCachedRigElement> ParentCaches;
}
