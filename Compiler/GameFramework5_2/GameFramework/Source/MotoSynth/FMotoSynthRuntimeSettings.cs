#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotoSynthPreset.h")]
public partial struct FMotoSynthRuntimeSettings {
	public bool bSynthToneEnabled;
	public float SynthToneVolume_DEPRECATED;
	public float SynthToneFilterFrequency_DEPRECATED;
	public FVector2D SynthToneVolumeRange;
	public FVector2D SynthToneFilterFrequencyRange;
	public bool bSynthToneEnvelopeEnabled;
	public FVector2D SynthToneAttackTimeMsecRange;
	public FVector2D SynthToneAttackCurveRange;
	public FVector2D SynthToneDecayTimeMsecRange;
	public FVector2D SynthToneDecayCurveRange;
	public int SynthOctaveShift;
	public bool bNoiseEnabled;
	public FVector2D NoiseVolumeRange;
	public bool bNoiseEnvelopeEnabled;
	public FVector2D NoiseLPFRange;
	public FVector2D NoiseAttackTimeMsecRange;
	public FVector2D NoiseAttackCurveRange;
	public FVector2D NoiseDecayTimeMsecRange;
	public FVector2D NoiseDecayCurveRange;
	public bool bGranularEngineEnabled;
	public float GranularEngineVolume;
	public float GranularEnginePitchScale;
	public int NumSamplesToCrossfadeBetweenGrains;
	public int NumGrainTableEntriesPerGrain;
	public int GrainTableRandomOffsetForConstantRPMs;
	public int GrainCrossfadeSamplesForConstantRPMs;
	public UMotoSynthSource AccelerationSource;
	public UMotoSynthSource DecelerationSource;
	public bool bStereoWidenerEnabled;
	public float StereoDelayMsec;
	public float StereoFeedback;
	public float StereoWidenerWetlevel;
	public float StereoWidenerDryLevel;
	public float StereoWidenerDelayRatio;
	public bool bStereoWidenerFilterEnabled;
	public float StereoWidenerFilterFrequency;
	public float StereoWidenerFilterQ;
}
