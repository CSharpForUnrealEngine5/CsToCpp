namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleLocationWorldOffset_Seeded.h")]
public partial class UParticleModuleLocationWorldOffset_Seeded : UParticleModuleLocationWorldOffset {
	public static UClass StaticClass() {return default;}
	///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
	public FParticleRandomSeedInfo RandomSeedInfo;
}
