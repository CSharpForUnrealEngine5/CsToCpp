#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleLODLevel.h")]
public partial class UParticleLODLevel : UObject {
// ParticleLODLevel
	public int Level;
	public bool bEnabled;
	public UParticleModuleRequired RequiredModule;
	public TArray<UParticleModule> Modules;
	public UParticleModuleTypeDataBase TypeDataModule;
	public UParticleModuleSpawn SpawnModule;
	public UParticleModuleEventGenerator EventGenerator;
	public TArray<UParticleModuleSpawnBase> SpawningModules;
	public TArray<UParticleModule> SpawnModules;
	public TArray<UParticleModule> UpdateModules;
	public TArray<UParticleModuleOrbit> OrbitModules;
	public TArray<UParticleModuleEventReceiverBase> EventReceiverModules;
	public bool ConvertedModules;
	public int PeakActiveParticles;
}
