#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Collision/ParticleModuleCollisionGPU.h")]
public partial class UParticleModuleCollisionGPU : UParticleModuleCollisionBase {
// ParticleModuleCollisionGPU
	public FRawDistributionFloat Resilience;
	public FRawDistributionFloat ResilienceScaleOverLife;
	public float Friction;
	public float RandomSpread;
	public float RandomDistribution;
	public float RadiusScale;
	public float RadiusBias;
	public byte Response;
	public byte CollisionMode;
}
