namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/SubmixEffectConvolutionReverb.h")]
public partial struct FSubmixEffectConvolutionReverbSettings {
	public float NormalizationVolumeDb;
	public float WetVolumeDb;
	public float DryVolumeDb;
	public bool bBypass;
	public bool bMixInputChannelFormatToImpulseResponseFormat;
	public bool bMixReverbOutputToOutputChannelFormat;
	public float SurroundRearChannelBleedDb;
	public bool bInvertRearChannelBleedPhase;
	public bool bSurroundRearChannelFlip;
	public float SurroundRearChannelBleedAmount_DEPRECATED;
	public UAudioImpulseResponse ImpulseResponse_DEPRECATED;
	public bool AllowHardwareAcceleration_DEPRECATED;
}
