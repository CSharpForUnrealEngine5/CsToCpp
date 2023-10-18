namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Constrains an item&#39;s scale to multiple items&#39; scales</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TransformConstraint.h")]
public partial struct FRigUnit_ScaleConstraintLocalSpaceOffset {
	public FRigElementKey Child;
	public bool bMaintainOffset;
	public FFilterOptionPerAxis Filter;
	public TArray<FConstraintParent> Parents;
	public float Weight;
	public FCachedRigElement ChildCache;
	public TArray<FCachedRigElement> ParentCaches;
}
