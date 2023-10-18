namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleLocation_Seeded.h")]
public partial class UParticleModuleLocation_Seeded : UParticleModuleLocation {
	public static UClass StaticClass() {return default;}
	///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
	public FParticleRandomSeedInfo RandomSeedInfo;
}
