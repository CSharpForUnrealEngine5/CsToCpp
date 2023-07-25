#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsCollisionHandler.h")]
public partial class UPhysicsCollisionHandler : UObject {
// PhysicsCollisionHandler
	public float ImpactThreshold;
	public float ImpactReFireDelay;
	public USoundBase DefaultImpactSound;
	public float LastImpactSoundTime;
}
