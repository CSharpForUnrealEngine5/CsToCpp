#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/SubmixEffectMultiBandCompressor.h")]
///<summary>A submix dynamics processor</summary>
public partial struct FSubmixEffectMultibandCompressorSettings {
// SubmixEffectMultibandCompressorSettings
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
