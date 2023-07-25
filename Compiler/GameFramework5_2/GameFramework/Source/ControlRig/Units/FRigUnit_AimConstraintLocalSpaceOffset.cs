#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_AimBone.h")]
///<summary>Orients an item such that its aim axis points towards a global target.</summary>
public partial struct FRigUnit_AimConstraintLocalSpaceOffset {
// RigUnit_AimConstraintLocalSpaceOffset
	public FRigElementKey Child;
	public bool bMaintainOffset;
	public FFilterOptionPerAxis Filter;
	public FVector AimAxis;
	public FVector UpAxis;
	public FRigUnit_AimConstraint_WorldUp WorldUp;
	public TArray<FConstraintParent> Parents;
	public FRigUnit_AimConstraint_AdvancedSettings AdvancedSettings;
	public float Weight;
	public FCachedRigElement WorldUpSpaceCache;
	public FCachedRigElement ChildCache;
	public TArray<FCachedRigElement> ParentCaches;
	public bool bIsInitialized;
}
