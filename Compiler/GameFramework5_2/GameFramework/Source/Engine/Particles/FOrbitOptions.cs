namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container struct for holding options on the data updating for the module.</summary>
[CppInclude("Particles/Orbit/ParticleModuleOrbit.h")]
public partial struct FOrbitOptions {
	public bool bProcessDuringSpawn;
	public bool bProcessDuringUpdate;
	public bool bUseEmitterTime;
}
