#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TransformConstraint.h")]
///<summary>Constrains an item's transform to multiple items' transforms</summary>
public partial struct FRigUnit_TransformConstraintPerItem {
// RigUnit_TransformConstraintPerItem
	public FRigElementKey Item;
	public ETransformSpaceMode BaseTransformSpace;
	public FTransform BaseTransform;
	public FRigElementKey BaseItem;
	public TArray<FConstraintTarget> Targets;
	public bool bUseInitialTransforms;
	public FRigUnit_TransformConstraint_WorkData WorkData;
}
