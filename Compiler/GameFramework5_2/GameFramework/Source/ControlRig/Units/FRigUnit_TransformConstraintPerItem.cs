#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Constrains an item&#39;s transform to multiple items&#39; transforms</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TransformConstraint.h")]
public partial struct FRigUnit_TransformConstraintPerItem {
	public FRigElementKey Item;
	public ETransformSpaceMode BaseTransformSpace;
	public FTransform BaseTransform;
	public FRigElementKey BaseItem;
	public TArray<FConstraintTarget> Targets;
	public bool bUseInitialTransforms;
	public FRigUnit_TransformConstraint_WorkData WorkData;
}
