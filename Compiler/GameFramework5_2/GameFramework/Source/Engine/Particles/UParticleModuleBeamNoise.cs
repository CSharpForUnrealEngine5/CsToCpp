#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Beam/ParticleModuleBeamNoise.h")]
public partial class UParticleModuleBeamNoise : UParticleModuleBeamBase {
// ParticleModuleBeamNoise
	public bool bLowFreq_Enabled;
	public int Frequency;
	public int Frequency_LowRange;
	public FRawDistributionVector NoiseRange;
	public FRawDistributionFloat NoiseRangeScale;
	public bool bNRScaleEmitterTime;
	public FRawDistributionVector NoiseSpeed;
	public bool bSmooth;
	public float NoiseLockRadius;
	public bool bNoiseLock;
	public bool bOscillate;
	public float NoiseLockTime;
	public float NoiseTension;
	public bool bUseNoiseTangents;
	public FRawDistributionFloat NoiseTangentStrength;
	public int NoiseTessellation;
	public bool bTargetNoise;
	public float FrequencyDistance;
	public bool bApplyNoiseScale;
	public FRawDistributionFloat NoiseScale;
}
