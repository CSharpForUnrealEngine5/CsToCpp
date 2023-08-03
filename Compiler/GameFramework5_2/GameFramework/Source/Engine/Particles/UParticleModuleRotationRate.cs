#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/RotationRate/ParticleModuleRotationRate.h")]
public partial class UParticleModuleRotationRate : UParticleModuleRotationRateBase {
	public static UClass StaticClass() {return default;}
	///<summary>Initial rotation rate, in rotations per second.</summary>
	public FRawDistributionFloat StartRotationRate;
}
