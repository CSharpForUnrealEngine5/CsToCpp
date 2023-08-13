namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Orbit/ParticleModuleOrbitBase.h")]
public partial class UParticleModuleOrbitBase : UParticleModule {
	public static UClass StaticClass() {return default;}
	///<summary>If true, distribution values will be retrieved using the EmitterTime.</summary>
	public bool bUseEmitterTime;
}
