#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Distance constraint</summary>
[CppInclude("PhysicsEngine/ConstraintTypes.h")]
public partial struct FLinearConstraint {
	public float Limit;
	public ELinearConstraintMotion XMotion;
	public ELinearConstraintMotion YMotion;
	public ELinearConstraintMotion ZMotion;
}
