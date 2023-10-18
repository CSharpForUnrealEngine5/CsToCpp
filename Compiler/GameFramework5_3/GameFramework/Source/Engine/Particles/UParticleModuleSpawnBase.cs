namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Spawn/ParticleModuleSpawnBase.h")]
public partial class UParticleModuleSpawnBase : UParticleModule {
	public static UClass StaticClass() {return default;}
	///<summary>If true, the SpawnRate of the SpawnModule of the emitter will be processed.</summary>
	public bool bProcessSpawnRate;
	///<summary>If true, the BurstList of the SpawnModule of the emitter will be processed.</summary>
	public bool bProcessBurstList;
}
