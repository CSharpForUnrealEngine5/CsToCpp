#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Angular roll constraint</summary>
[CppInclude("PhysicsEngine/ConstraintTypes.h")]
public partial struct FTwistConstraint {
	public float TwistLimitDegrees;
	public EAngularConstraintMotion TwistMotion;
}
