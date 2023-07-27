#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Orbit/ParticleModuleOrbit.h")]
public partial class UParticleModuleOrbit : UParticleModuleOrbitBase {
// ParticleModuleOrbit
	public EOrbitChainMode ChainMode;
	public FRawDistributionVector OffsetAmount;
	public FOrbitOptions OffsetOptions;
	public FRawDistributionVector RotationAmount;
	public FOrbitOptions RotationOptions;
	public FRawDistributionVector RotationRateAmount;
	public FOrbitOptions RotationRateOptions;
}
