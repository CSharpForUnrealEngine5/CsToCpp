#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ConstraintDrives.h")]
public partial struct FConstraintDrive {
	public float Stiffness;
	public float Damping;
	public float MaxForce;
	public bool bEnablePositionDrive;
	public bool bEnableVelocityDrive;
}
