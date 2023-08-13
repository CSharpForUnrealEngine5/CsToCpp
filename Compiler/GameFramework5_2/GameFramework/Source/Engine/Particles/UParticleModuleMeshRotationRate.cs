namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/RotationRate/ParticleModuleMeshRotationRate.h")]
public partial class UParticleModuleMeshRotationRate : UParticleModuleRotationRateBase {
	public static UClass StaticClass() {return default;}
	///<summary>Initial rotation rate, in rotations per second.</summary>
	public FRawDistributionVector StartRotationRate;
}
