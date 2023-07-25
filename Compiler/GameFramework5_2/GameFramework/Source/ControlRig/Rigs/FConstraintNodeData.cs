#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/AnimationHierarchy.h")]
public partial struct FConstraintNodeData {
// ConstraintNodeData
	public FTransform RelativeParent;
	public FConstraintOffset ConstraintOffset;
	public string LinkedNode;
	public TArray<FTransformConstraint> Constraints;
}
