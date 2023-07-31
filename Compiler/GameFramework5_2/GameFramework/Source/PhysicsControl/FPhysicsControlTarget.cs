#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a target position and orientation, and also the target velocity and angular velocity.</summary>
[CppInclude("PhysicsControlData.h")]
public partial struct FPhysicsControlTarget {
	public FVector TargetPosition;
	public FVector TargetVelocity;
	public FRotator TargetOrientation;
	public FVector TargetAngularVelocity;
	public bool bApplyControlPointToTarget;
}
