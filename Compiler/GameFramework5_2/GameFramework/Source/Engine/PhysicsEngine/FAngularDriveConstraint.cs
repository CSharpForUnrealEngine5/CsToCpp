#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ConstraintDrives.h")]
///<summary>Angular Drive</summary>
public partial struct FAngularDriveConstraint {
// AngularDriveConstraint
	public FConstraintDrive TwistDrive;
	public FConstraintDrive SwingDrive;
	public FConstraintDrive SlerpDrive;
	public FRotator OrientationTarget;
	public FVector AngularVelocityTarget;
	public byte AngularDriveMode;
}
