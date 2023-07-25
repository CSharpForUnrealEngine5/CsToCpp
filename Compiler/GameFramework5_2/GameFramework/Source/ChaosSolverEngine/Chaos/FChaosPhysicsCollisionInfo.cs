#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosNotifyHandlerInterface.h")]
public partial struct FChaosPhysicsCollisionInfo {
// ChaosPhysicsCollisionInfo
	public UPrimitiveComponent Component;
	public UPrimitiveComponent OtherComponent;
	public FVector Location;
	public FVector Normal;
	public FVector AccumulatedImpulse;
	public FVector Velocity;
	public FVector OtherVelocity;
	public FVector AngularVelocity;
	public FVector OtherAngularVelocity;
	public float Mass;
	public float OtherMass;
}
