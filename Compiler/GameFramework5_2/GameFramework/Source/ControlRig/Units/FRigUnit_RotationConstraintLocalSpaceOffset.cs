#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TransformConstraint.h")]
///<summary>Constrains an item's rotation to multiple items' rotations</summary>
public partial struct FRigUnit_RotationConstraintLocalSpaceOffset {
// RigUnit_RotationConstraintLocalSpaceOffset
	public FRigElementKey Child;
	public bool bMaintainOffset;
	public FFilterOptionPerAxis Filter;
	public TArray<FConstraintParent> Parents;
	public FRigUnit_RotationConstraint_AdvancedSettings AdvancedSettings;
	public float Weight;
	public FCachedRigElement ChildCache;
	public TArray<FCachedRigElement> ParentCaches;
}
