#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Constrains an item&#39;s transform to multiple items&#39; transforms</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TransformConstraint.h")]
public partial struct FRigUnit_ParentConstraint {
	public FRigElementKey Child;
	public bool bMaintainOffset;
	public FTransformFilter Filter;
	public TArray<FConstraintParent> Parents;
	public FRigUnit_ParentConstraint_AdvancedSettings AdvancedSettings;
	public float Weight;
	public FCachedRigElement ChildCache;
	public TArray<FCachedRigElement> ParentCaches;
}
