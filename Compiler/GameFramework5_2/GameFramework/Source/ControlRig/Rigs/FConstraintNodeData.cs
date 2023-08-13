namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/AnimationHierarchy.h")]
public partial struct FConstraintNodeData {
	public FTransform RelativeParent;
	public FConstraintOffset ConstraintOffset;
	public string LinkedNode;
	public TArray<FTransformConstraint> Constraints;
}
