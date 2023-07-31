#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Constraint.h")]
public partial struct FTransformConstraint {
	public FConstraintDescription Operator;
	public string SourceNode;
	public string TargetNode;
	public float Weight;
	public bool bMaintainOffset;
}
