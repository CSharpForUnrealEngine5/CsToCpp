#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ConstraintTypes.h")]
///<summary>Cone constraint</summary>
public partial struct FConeConstraint {
// ConeConstraint
	public float Swing1LimitDegrees;
	public float Swing2LimitDegrees;
	public EAngularConstraintMotion Swing1Motion;
	public EAngularConstraintMotion Swing2Motion;
}
