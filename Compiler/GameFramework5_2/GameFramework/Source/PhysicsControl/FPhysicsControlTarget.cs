#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlData.h")]
///<summary>Defines a target position and orientation, and also the target velocity and angular velocity.</summary>
public partial struct FPhysicsControlTarget {
// PhysicsControlTarget
	public FVector TargetPosition;
	public FVector TargetVelocity;
	public FRotator TargetOrientation;
	public FVector TargetAngularVelocity;
	public bool bApplyControlPointToTarget;
}
