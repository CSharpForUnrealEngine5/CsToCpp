#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ConstraintTypes.h")]
///<summary>Distance constraint</summary>
public partial struct FLinearConstraint {
// LinearConstraint
	public float Limit;
	public ELinearConstraintMotion XMotion;
	public ELinearConstraintMotion YMotion;
	public ELinearConstraintMotion ZMotion;
}
