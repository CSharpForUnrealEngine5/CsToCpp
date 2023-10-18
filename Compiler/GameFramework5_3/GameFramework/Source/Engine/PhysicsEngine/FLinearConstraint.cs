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
