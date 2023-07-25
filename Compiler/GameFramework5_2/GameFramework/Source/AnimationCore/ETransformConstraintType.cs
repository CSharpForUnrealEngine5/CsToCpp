#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Constraint.h")]
///<summary>Transform Constraint Types</summary>
public enum ETransformConstraintType {
	Translation=0,
	Rotation=1,
	Scale=2,
	Parent=3,
	LookAt=4,
}
