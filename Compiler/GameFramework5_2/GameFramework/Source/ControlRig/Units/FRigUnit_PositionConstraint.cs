namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Constrains an item&#39;s position to multiple items&#39; positions</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TransformConstraint.h")]
public partial struct FRigUnit_PositionConstraint {
	public FRigElementKey Child;
	public bool bMaintainOffset;
	public FFilterOptionPerAxis Filter;
	public TArray<FConstraintParent> Parents;
	public float Weight;
}
