namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Lifetime/ParticleModuleLifetime.h")]
public partial class UParticleModuleLifetime : UParticleModuleLifetimeBase {
	public static UClass StaticClass() {return default;}
	///<summary>The lifetime of the particle, in seconds. Retrieved using the EmitterTime at the spawn of the particle.</summary>
	public FRawDistributionFloat Lifetime;
}
