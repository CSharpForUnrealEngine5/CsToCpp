#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Spawn/ParticleModuleSpawnBase.h")]
public partial class UParticleModuleSpawnBase : UParticleModule {
	///<summary>If true, the SpawnRate of the SpawnModule of the emitter will be processed.</summary>
	public bool bProcessSpawnRate;
	///<summary>If true, the BurstList of the SpawnModule of the emitter will be processed.</summary>
	public bool bProcessBurstList;
}
