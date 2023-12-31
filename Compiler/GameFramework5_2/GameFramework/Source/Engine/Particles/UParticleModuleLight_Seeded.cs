namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Light/ParticleModuleLight_Seeded.h")]
public partial class UParticleModuleLight_Seeded : UParticleModuleLight {
	public static UClass StaticClass() {return default;}
	///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
	public FParticleRandomSeedInfo RandomSeedInfo;
}
