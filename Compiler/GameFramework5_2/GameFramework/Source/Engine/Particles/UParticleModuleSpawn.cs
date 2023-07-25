#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Spawn/ParticleModuleSpawn.h")]
public partial class UParticleModuleSpawn : UParticleModuleSpawnBase {
// ParticleModuleSpawn
	public FRawDistributionFloat Rate;
	public FRawDistributionFloat RateScale;
	public TArray<FParticleBurst> BurstList;
	public FRawDistributionFloat BurstScale;
	public byte ParticleBurstMethod;
	public bool bApplyGlobalSpawnRateScale;
}
