namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/RotationRate/ParticleModuleMeshRotationRate_Seeded.h")]
public partial class UParticleModuleMeshRotationRate_Seeded : UParticleModuleMeshRotationRate {
	public static UClass StaticClass() {return default;}
	///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
	public FParticleRandomSeedInfo RandomSeedInfo;
}
