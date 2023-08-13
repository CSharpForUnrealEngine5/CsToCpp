namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Parameter/ParticleModuleParameterDynamic_Seeded.h")]
public partial class UParticleModuleParameterDynamic_Seeded : UParticleModuleParameterDynamic {
	public static UClass StaticClass() {return default;}
	///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
	public FParticleRandomSeedInfo RandomSeedInfo;
}
