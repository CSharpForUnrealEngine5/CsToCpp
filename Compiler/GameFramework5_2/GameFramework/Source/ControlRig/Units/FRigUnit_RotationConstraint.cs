namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Constrains an item&#39;s rotation to multiple items&#39; rotations</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TransformConstraint.h")]
public partial struct FRigUnit_RotationConstraint {
	public FRigElementKey Child;
	public bool bMaintainOffset;
	public FFilterOptionPerAxis Filter;
	public TArray<FConstraintParent> Parents;
	public FRigUnit_RotationConstraint_AdvancedSettings AdvancedSettings;
	public float Weight;
}
