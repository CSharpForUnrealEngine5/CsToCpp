namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Spawn/ParticleModuleSpawn.h")]
public partial class UParticleModuleSpawn : UParticleModuleSpawnBase {
	public static UClass StaticClass() {return default;}
	///<summary>The rate at which to spawn particles.</summary>
	public FRawDistributionFloat Rate;
	///<summary>The scalar to apply to the rate.</summary>
	public FRawDistributionFloat RateScale;
	///<summary>The array of burst entries.</summary>
	public TArray<FParticleBurst> BurstList;
	///<summary>Scale all burst entries by this amount.</summary>
	public FRawDistributionFloat BurstScale;
	///<summary>The method to utilize when burst-emitting particles.</summary>
	public EParticleBurstMethod ParticleBurstMethod;
	///<summary>If true, the SpawnRate will be scaled by the global CVar r.EmitterSpawnRateScale</summary>
	public bool bApplyGlobalSpawnRateScale;
}
