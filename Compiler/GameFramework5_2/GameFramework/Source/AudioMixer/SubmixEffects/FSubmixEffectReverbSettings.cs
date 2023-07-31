#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/AudioMixerSubmixEffectReverb.h")]
public partial struct FSubmixEffectReverbSettings {
	public bool bBypassEarlyReflections;
	public float ReflectionsDelay;
	public float GainHF;
	public float ReflectionsGain;
	public bool bBypassLateReflections;
	public float LateDelay;
	public float DecayTime;
	public float Density;
	public float Diffusion;
	public float AirAbsorptionGainHF;
	public float DecayHFRatio;
	public float LateGain;
	public float Gain;
	public float WetLevel;
	public float DryLevel;
	public bool bBypass;
}
