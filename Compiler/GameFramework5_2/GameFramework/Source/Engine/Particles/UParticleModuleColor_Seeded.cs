namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Color/ParticleModuleColor_Seeded.h")]
public partial class UParticleModuleColor_Seeded : UParticleModuleColor {
	public static UClass StaticClass() {return default;}
	///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
	public FParticleRandomSeedInfo RandomSeedInfo;
}
