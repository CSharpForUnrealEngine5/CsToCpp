namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Angular roll constraint</summary>
[CppInclude("PhysicsEngine/ConstraintTypes.h")]
public partial struct FTwistConstraint {
	public float TwistLimitDegrees;
	public EAngularConstraintMotion TwistMotion;
}
