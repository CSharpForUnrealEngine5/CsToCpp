#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Orbit/ParticleModuleOrbit.h")]
///<summary>Container struct for holding options on the data updating for the module.</summary>
public partial struct FOrbitOptions {
// OrbitOptions
	public bool bProcessDuringSpawn;
	public bool bProcessDuringUpdate;
	public bool bUseEmitterTime;
}
