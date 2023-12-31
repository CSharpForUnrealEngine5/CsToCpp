namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Lifetime/ParticleModuleLifetime_Seeded.h")]
public partial class UParticleModuleLifetime_Seeded : UParticleModuleLifetime {
	public static UClass StaticClass() {return default;}
	///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
	public FParticleRandomSeedInfo RandomSeedInfo;
}
