#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Lifetime/ParticleModuleLifetime.h")]
public partial class UParticleModuleLifetime : UParticleModuleLifetimeBase {
	///<summary>The lifetime of the particle, in seconds. Retrieved using the EmitterTime at the spawn of the particle.</summary>
	public FRawDistributionFloat Lifetime;
}
