namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A submix dynamics processor</summary>
[CppInclude("SubmixEffects/SubmixEffectMultiBandCompressor.h")]
public partial struct FSubmixEffectMultibandCompressorSettings {
	public ESubmixEffectDynamicsProcessorType DynamicsProcessorType;
	public ESubmixEffectDynamicsPeakMode PeakMode;
	public ESubmixEffectDynamicsChannelLinkMode LinkMode;
	public float LookAheadMsec;
	public bool bAnalogMode;
	public bool bFourPole;
	public bool bBypass;
	public ESubmixEffectDynamicsKeySource KeySource;
	public UAudioBus ExternalAudioBus;
	public USoundSubmix ExternalSubmix;
	public float KeyGainDb;
	public bool bKeyAudition;
	public TArray<FDynamicsBandSettings> Bands;
}
