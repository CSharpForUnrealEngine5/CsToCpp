#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TransformConstraint.h")]
public partial struct FRigUnit_TransformConstraint {
// RigUnit_TransformConstraint
	public string Bone;
	public ETransformSpaceMode BaseTransformSpace;
	public FTransform BaseTransform;
	public string BaseBone;
	public TArray<FConstraintTarget> Targets;
	public bool bUseInitialTransforms;
	public FRigUnit_TransformConstraint_WorkData WorkData;
}
