namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Rotation/ParticleModuleRotation_Seeded.h")]
public partial class UParticleModuleRotation_Seeded : UParticleModuleRotation {
	public static UClass StaticClass() {return default;}
	///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
	public FParticleRandomSeedInfo RandomSeedInfo;
}
