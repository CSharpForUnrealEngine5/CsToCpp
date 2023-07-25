#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TransformConstraint.h")]
///<summary>Constrains an item's transform to multiple items' transforms</summary>
public partial struct FRigUnit_ParentConstraint {
// RigUnit_ParentConstraint
	public FRigElementKey Child;
	public bool bMaintainOffset;
	public FTransformFilter Filter;
	public TArray<FConstraintParent> Parents;
	public FRigUnit_ParentConstraint_AdvancedSettings AdvancedSettings;
	public float Weight;
	public FCachedRigElement ChildCache;
	public TArray<FCachedRigElement> ParentCaches;
}
