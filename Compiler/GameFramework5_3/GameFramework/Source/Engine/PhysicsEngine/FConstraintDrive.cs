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
