namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Velocity/ParticleModuleVelocity_Seeded.h")]
public partial class UParticleModuleVelocity_Seeded : UParticleModuleVelocity {
	public static UClass StaticClass() {return default;}
	///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
	public FParticleRandomSeedInfo RandomSeedInfo;
}
