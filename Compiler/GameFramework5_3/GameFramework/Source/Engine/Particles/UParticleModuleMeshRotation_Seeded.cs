namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Rotation/ParticleModuleMeshRotation_Seeded.h")]
public partial class UParticleModuleMeshRotation_Seeded : UParticleModuleMeshRotation {
	public static UClass StaticClass() {return default;}
	///<summary>The random seed(s) to use for looking up values in StartLocation</summary>
	public FParticleRandomSeedInfo RandomSeedInfo;
}
