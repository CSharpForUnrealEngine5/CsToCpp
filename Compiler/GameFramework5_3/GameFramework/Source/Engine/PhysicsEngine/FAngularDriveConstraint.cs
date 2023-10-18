namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Angular Drive</summary>
[CppInclude("PhysicsEngine/ConstraintDrives.h")]
public partial struct FAngularDriveConstraint {
	public FConstraintDrive TwistDrive;
	public FConstraintDrive SwingDrive;
	public FConstraintDrive SlerpDrive;
	public FRotator OrientationTarget;
	public FVector AngularVelocityTarget;
	public EAngularDriveMode AngularDriveMode;
}
