#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockPhysicsGrenade.h")]
public partial class UMockPhysicsGrenadeComponent : UNetworkPredictionPhysicsComponent {
// MockPhysicsGrenadeComponent
	public void FMockGrenadeOnExplode() {}
	public FMockGrenadeOnExplode OnExplode;
	public float FuseTimeSeconds;
	public float Radius;
	public float Magnitude;
}
