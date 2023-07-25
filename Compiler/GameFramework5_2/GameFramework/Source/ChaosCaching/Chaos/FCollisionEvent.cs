#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/Adapters/GeometryCollectionComponentCacheAdapter.h")]
public partial struct FCollisionEvent {
// CollisionEvent
	public FVector Location;
	public FVector AccumulatedImpulse;
	public FVector Normal;
	public FVector Velocity1;
	public FVector Velocity2;
	public FVector DeltaVelocity1;
	public FVector DeltaVelocity2;
	public FVector AngularVelocity1;
	public FVector AngularVelocity2;
	public float Mass1;
	public float Mass2;
	public float PenetrationDepth;
}
