#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/AudioSettings.h")]
///<summary>Audio settings.</summary>
public partial class UAudioSettings : UDeveloperSettings {
// AudioSettings
	public FSoftObjectPath DefaultSoundClassName;
	public FSoftObjectPath DefaultMediaSoundClassName;
	public FSoftObjectPath DefaultSoundConcurrencyName;
	public FSoftObjectPath DefaultBaseSoundMix;
	public FSoftObjectPath VoiPSoundClass;
	public FSoftObjectPath MasterSubmix;
	public FSoftObjectPath BaseDefaultSubmix;
	public FSoftObjectPath ReverbSubmix;
	public FSoftObjectPath EQSubmix;
	public EVoiceSampleRate VoiPSampleRate;
	public EDefaultAudioCompressionType DefaultAudioCompressionType;
	public float DefaultReverbSendLevel_DEPRECATED;
	public int MaximumConcurrentStreams;
	public float GlobalMinPitchScale;
	public float GlobalMaxPitchScale;
	public TArray<FAudioQualitySettings> QualityLevels;
	public bool bAllowPlayWhenSilent;
	public bool bDisableMasterEQ;
	public bool bAllowCenterChannel3DPanning;
	public uint NumStoppingSources;
	public EPanningMethod PanningMethod;
	public EMonoChannelUpmixMethod MonoChannelUpmixMethod;
	public string DialogueFilenameFormat;
	public TArray<FSoundDebugEntry> DebugSounds;
	public TArray<FDefaultAudioBusSettings> DefaultAudioBuses;
	public USoundClass DefaultSoundClass;
	public USoundClass DefaultMediaSoundClass;
	public USoundConcurrency DefaultSoundConcurrency;
}
