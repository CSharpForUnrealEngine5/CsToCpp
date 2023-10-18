namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Audio settings.</summary>
[CppInclude("Sound/AudioSettings.h")]
public partial class UAudioSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The SoundClass assigned to newly created sounds</summary>
	public FSoftObjectPath DefaultSoundClassName;
	///<summary>The SoundClass assigned to media player assets</summary>
	public FSoftObjectPath DefaultMediaSoundClassName;
	///<summary>The SoundConcurrency assigned to newly created sounds</summary>
	public FSoftObjectPath DefaultSoundConcurrencyName;
	///<summary>The SoundMix to use as base when no other system has specified a Base SoundMix</summary>
	public FSoftObjectPath DefaultBaseSoundMix;
	///<summary>Sound class to be used for the VOIP audio component</summary>
	public FSoftObjectPath VoiPSoundClass;
	///<summary>The default submix through which all sounds are routed to. The root submix that outputs to audio hardware.</summary>
	public FSoftObjectPath MasterSubmix;
	///<summary>The default submix to use for implicit submix sends (i.e. if the base submix send is null or if a submix parent is null)</summary>
	public FSoftObjectPath BaseDefaultSubmix;
	///<summary>The submix through which all sounds set to use reverb are routed</summary>
	public FSoftObjectPath ReverbSubmix;
	///<summary>The submix through which all sounds set to use legacy EQ system are routed</summary>
	public FSoftObjectPath EQSubmix;
	///<summary>Sample rate used for voice over IP. VOIP audio is resampled to the application&#39;s sample rate on the receiver side.</summary>
	public EVoiceSampleRate VoiPSampleRate;
	///<summary>Default audio compression type to use for audio assets.</summary>
	public EDefaultAudioCompressionType DefaultAudioCompressionType;
	///<summary>The default compression quality (e.g. for new SoundWaves)</summary>
	public int DefaultCompressionQuality;
	///<summary>The amount of audio to send to reverb submixes if no reverb send is setup for the source through attenuation settings. Only used in audio mixer.</summary>
	public float DefaultReverbSendLevel_DEPRECATED;
	///<summary>How many streaming sounds can be played at the same time (if more are played they will be sorted by priority)</summary>
	public int MaximumConcurrentStreams;
	///<summary>The value to use to clamp the min pitch scale</summary>
	public float GlobalMinPitchScale;
	///<summary>The value to use to clamp the max pitch scale</summary>
	public float GlobalMaxPitchScale;
	///<summary>QualityLevels</summary>
	public TArray<FAudioQualitySettings> QualityLevels;
	///<summary>Allows sounds to play at 0 volume.</summary>
	public bool bAllowPlayWhenSilent;
	///<summary>Disables master EQ effect in the audio DSP graph.</summary>
	public bool bDisableMasterEQ;
	///<summary>Enables the surround sound spatialization calculations to include the center channel.</summary>
	public bool bAllowCenterChannel3DPanning;
	///<summary>The max number of sources to reserve for &quot;stopping&quot; sounds. A &quot;stopping&quot; sound applies a fast fade in the DSP</summary>
	public uint NumStoppingSources;
	///<summary>The method to use when doing non-binaural or object-based panning.</summary>
	public EPanningMethod PanningMethod;
	///<summary>The upmixing method for mono sound sources. Defines how mono channels are up-mixed to stereo channels.</summary>
	public EMonoChannelUpmixMethod MonoChannelUpmixMethod;
	///<summary>The format string to use when generating the filename for contexts within dialogue waves. This must generate unique names for your project.</summary>
	public string DialogueFilenameFormat;
	///<summary>Sounds only packaged in non-shipped builds for debugging.</summary>
	public TArray<FSoundDebugEntry> DebugSounds;
	///<summary>Array of AudioBuses that are automatically initialized when the AudioEngine is initialized</summary>
	public TArray<FDefaultAudioBusSettings> DefaultAudioBuses;
	///<summary>DefaultSoundClass</summary>
	public USoundClass DefaultSoundClass;
	///<summary>DefaultMediaSoundClass</summary>
	public USoundClass DefaultMediaSoundClass;
	///<summary>DefaultSoundConcurrency</summary>
	public USoundConcurrency DefaultSoundConcurrency;
}
