namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Constraint.h")]
public partial struct FTransformConstraint {
	public FConstraintDescription Operator;
	public FName SourceNode;
	public FName TargetNode;
	public float Weight;
	public bool bMaintainOffset;
}
