#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cone constraint</summary>
[CppInclude("PhysicsEngine/ConstraintTypes.h")]
public partial struct FConeConstraint {
	public float Swing1LimitDegrees;
	public float Swing2LimitDegrees;
	public EAngularConstraintMotion Swing1Motion;
	public EAngularConstraintMotion Swing2Motion;
}
