#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleLODLevel.h")]
public partial class UParticleLODLevel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The index value of the LOD level</summary>
	public int Level;
	///<summary>True if the LOD level is enabled, meaning it should be updated and rendered.</summary>
	public bool bEnabled;
	///<summary>The required module for this LOD level</summary>
	public UParticleModuleRequired RequiredModule;
	///<summary>An array of particle modules that contain the adjusted data for the LOD level</summary>
	public TArray<UParticleModule> Modules;
	///<summary>Module&lt;SINGULAR&gt; used for emitter type &quot;extension&quot;.</summary>
	public UParticleModuleTypeDataBase TypeDataModule;
	///<summary>The SpawnRate/Burst module - required by all emitters.</summary>
	public UParticleModuleSpawn SpawnModule;
	///<summary>The optional EventGenerator module.</summary>
	public UParticleModuleEventGenerator EventGenerator;
	///<summary>SpawningModules - These are called to determine how many particles to spawn.</summary>
	public TArray<UParticleModuleSpawnBase> SpawningModules;
	///<summary>SpawnModules - These are called when particles are spawned.</summary>
	public TArray<UParticleModule> SpawnModules;
	///<summary>UpdateModules - These are called when particles are updated.</summary>
	public TArray<UParticleModule> UpdateModules;
	///<summary>OrbitModules</summary>
	public TArray<UParticleModuleOrbit> OrbitModules;
	///<summary>Event receiver modules only!</summary>
	public TArray<UParticleModuleEventReceiverBase> EventReceiverModules;
	///<summary>ConvertedModules</summary>
	public bool ConvertedModules;
	///<summary>PeakActiveParticles</summary>
	public int PeakActiveParticles;
}
