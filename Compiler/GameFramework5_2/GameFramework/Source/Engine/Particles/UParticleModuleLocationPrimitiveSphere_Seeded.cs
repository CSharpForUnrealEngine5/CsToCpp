namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleLocationPrimitiveSphere_Seeded.h")]
public partial class UParticleModuleLocationPrimitiveSphere_Seeded : UParticleModuleLocationPrimitiveSphere {
	public static UClass StaticClass() {return default;}
	///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
	public FParticleRandomSeedInfo RandomSeedInfo;
}
