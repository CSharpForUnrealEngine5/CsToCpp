#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Submix dynamics processor settings</summary>
[CppInclude("SubmixEffects/AudioMixerSubmixEffectDynamicsProcessor.h")]
public partial struct FSubmixEffectDynamicsProcessorSettings {
	public ESubmixEffectDynamicsProcessorType DynamicsProcessorType;
	public ESubmixEffectDynamicsPeakMode PeakMode;
	public ESubmixEffectDynamicsChannelLinkMode LinkMode;
	public float InputGainDb;
	public float ThresholdDb;
	public float Ratio;
	public float KneeBandwidthDb;
	public float LookAheadMsec;
	public float AttackTimeMsec;
	public float ReleaseTimeMsec;
	public ESubmixEffectDynamicsKeySource KeySource;
	public UAudioBus ExternalAudioBus;
	public USoundSubmix ExternalSubmix;
	public bool bChannelLinked_DEPRECATED;
	public bool bAnalogMode;
	public bool bBypass;
	public bool bKeyAudition;
	public float KeyGainDb;
	public float OutputGainDb;
	public FSubmixEffectDynamicProcessorFilterSettings KeyHighshelf;
	public FSubmixEffectDynamicProcessorFilterSettings KeyLowshelf;
}
