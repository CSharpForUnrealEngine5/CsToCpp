#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linear Drive</summary>
[CppInclude("PhysicsEngine/ConstraintDrives.h")]
public partial struct FLinearDriveConstraint {
	public FVector PositionTarget;
	public FVector VelocityTarget;
	public FConstraintDrive XDrive;
	public FConstraintDrive YDrive;
	public FConstraintDrive ZDrive;
	public bool bEnablePositionDrive;
}
