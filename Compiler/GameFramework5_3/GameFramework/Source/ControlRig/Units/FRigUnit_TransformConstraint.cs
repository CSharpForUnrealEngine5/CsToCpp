namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TransformConstraint.h")]
public partial struct FRigUnit_TransformConstraint {
	public FName Bone;
	public ETransformSpaceMode BaseTransformSpace;
	public FTransform BaseTransform;
	public FName BaseBone;
	public TArray<FConstraintTarget> Targets;
	public bool bUseInitialTransforms;
	public FRigUnit_TransformConstraint_WorkData WorkData;
}
