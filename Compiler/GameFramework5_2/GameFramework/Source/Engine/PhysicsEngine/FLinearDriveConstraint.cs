#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ConstraintDrives.h")]
///<summary>Linear Drive</summary>
public partial struct FLinearDriveConstraint {
// LinearDriveConstraint
	public FVector PositionTarget;
	public FVector VelocityTarget;
	public FConstraintDrive XDrive;
	public FConstraintDrive YDrive;
	public FConstraintDrive ZDrive;
	public bool bEnablePositionDrive;
}
