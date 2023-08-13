namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Beam/ParticleModuleBeamNoise.h")]
public partial class UParticleModuleBeamNoise : UParticleModuleBeamBase {
	public static UClass StaticClass() {return default;}
	///<summary>Is low frequency noise enabled.</summary>
	public bool bLowFreq_Enabled;
	///<summary>The frequency of noise points.</summary>
	public int Frequency;
	///<summary>If not 0, then the frequency will select a random value in the range</summary>
	public int Frequency_LowRange;
	///<summary>The noise point ranges.</summary>
	public FRawDistributionVector NoiseRange;
	///<summary>A scale factor that will be applied to the noise range.</summary>
	public FRawDistributionFloat NoiseRangeScale;
	///<summary>If true,  the NoiseRangeScale will be grabbed based on the emitter time.</summary>
	public bool bNRScaleEmitterTime;
	///<summary>The speed with which to move each noise point.</summary>
	public FRawDistributionVector NoiseSpeed;
	///<summary>Whether the noise movement should be smooth or &#39;jerky&#39;.</summary>
	public bool bSmooth;
	///<summary>Default target-point information to use if the beam method is endpoint.</summary>
	public float NoiseLockRadius;
	///<summary>INTERNAL - Whether the noise points should be locked.</summary>
	public bool bNoiseLock;
	///<summary>Whether the noise points should be oscillate.</summary>
	public bool bOscillate;
	///<summary>How long the  noise points should be locked - 0.0 indicates forever.</summary>
	public float NoiseLockTime;
	///<summary>The tension to apply to the tessellated noise line.</summary>
	public float NoiseTension;
	///<summary>If true, calculate tangents at each noise point.</summary>
	public bool bUseNoiseTangents;
	///<summary>The strength of noise tangents, if enabled.</summary>
	public FRawDistributionFloat NoiseTangentStrength;
	///<summary>The amount of tessellation between noise points.</summary>
	public int NoiseTessellation;
	///<summary>Whether to apply noise to the target point (or end of line in distance mode...)</summary>
	public bool bTargetNoise;
	///<summary>The distance at which to deposit noise points.</summary>
	public float FrequencyDistance;
	///<summary>If true, apply the noise scale to the beam.</summary>
	public bool bApplyNoiseScale;
	///<summary>The scale factor to apply to noise range.</summary>
	public FRawDistributionFloat NoiseScale;
}
