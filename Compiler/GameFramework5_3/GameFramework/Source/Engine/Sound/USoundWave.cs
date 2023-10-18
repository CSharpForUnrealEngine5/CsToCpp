namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundWave.h")]
public partial class USoundWave : USoundBase {
	public static UClass StaticClass() {return default;}
	///<summary>Platform agnostic compression quality. 1..100 with 1 being best compression and 100 being best quality. ADPCM and PCM sound asset compression types ignore this parameter.</summary>
	public int CompressionQuality;
	///<summary>StreamingPriority</summary>
	public int StreamingPriority;
	///<summary>Quality of sample rate conversion for platforms that opt into resampling during cook. The sample rate for each enumeration is definable per platform in platform target settings.</summary>
	public ESoundwaveSampleRateSettings SampleRateQuality;
	///<summary>SoundGroup</summary>
	public ESoundGroup SoundGroup;
	///<summary>If set, when played directly (not through a sound cue) the wave will be played looping.</summary>
	public bool bLooping;
	///<summary>Here for legacy code.</summary>
	public bool bStreaming;
	///<summary>The compression type to use for the sound wave asset.</summary>
	public ESoundAssetCompressionType SoundAssetCompressionType;
	///<summary>Deprecated compression type properties</summary>
	public bool bSeekableStreaming;
	///<summary>bUseBinkAudio</summary>
	public bool bUseBinkAudio;
	///<summary>Returns the sound&#39;s asset compression type.</summary>
	public ESoundAssetCompressionType GetSoundAssetCompressionType() { return default; }
	///<summary>Procedurally set the compression type.</summary>
	public void SetSoundAssetCompressionType(ESoundAssetCompressionType InSoundAssetCompressionType,bool bMarkDirty/*=true*/) {}
	///<summary>Filters for the cue points that are _not_ loop regions and returns those as a new array</summary>
	public TArray<FSoundWaveCuePoint> GetCuePoints() { return default; }
	///<summary>Filters for the cue points that _are_ loop regions and returns those as a new array</summary>
	public TArray<FSoundWaveCuePoint> GetLoopRegions() { return default; }
	///<summary>Specify a sound to use for the baked analysis. Will default to this USoundWave if not set.</summary>
	public USoundWave OverrideSoundToUseForAnalysis;
	///<summary>Whether or not we should treat the sound wave used for analysis (this or the override) as looping while performing analysis.</summary>
	public bool TreatFileAsLoopingForAnalysis;
	///<summary>Whether or not to enable cook-time baked FFT analysis.</summary>
	public bool bEnableBakedFFTAnalysis;
	///<summary>Whether or not to enable cook-time amplitude envelope analysis.</summary>
	public bool bEnableAmplitudeEnvelopeAnalysis;
	///<summary>The FFT window size to use for fft analysis.</summary>
	public ESoundWaveFFTSize FFTSize;
	///<summary>How many audio frames analyze at a time.</summary>
	public int FFTAnalysisFrameSize;
	///<summary>Attack time in milliseconds of the spectral envelope follower.</summary>
	public int FFTAnalysisAttackTime;
	///<summary>Release time in milliseconds of the spectral envelope follower.</summary>
	public int FFTAnalysisReleaseTime;
	///<summary>How many audio frames to average a new envelope value. Larger values use less memory for audio envelope data but will result in lower envelope accuracy.</summary>
	public int EnvelopeFollowerFrameSize;
	///<summary>The attack time in milliseconds. Describes how quickly the envelope analyzer responds to increasing amplitudes.</summary>
	public int EnvelopeFollowerAttackTime;
	///<summary>The release time in milliseconds. Describes how quickly the envelope analyzer responds to decreasing amplitudes.</summary>
	public int EnvelopeFollowerReleaseTime;
	///<summary>Modulation Settings</summary>
	public FSoundModulationDefaultRoutingSettings ModulationSettings;
	///<summary>The frequencies (in hz) to analyze when doing baked FFT analysis.</summary>
	public TArray<float> FrequenciesToAnalyze;
	///<summary>The cooked spectral time data.</summary>
	public TArray<FSoundWaveSpectralTimeData> CookedSpectralTimeData;
	///<summary>The cooked cooked envelope data.</summary>
	public TArray<FSoundWaveEnvelopeTimeData> CookedEnvelopeTimeData;
	///<summary>Use this to override how much audio data is loaded when this USoundWave is loaded.</summary>
	public int InitialChunkSize;
	///<summary>If set to true if this sound is considered to contain mature/adult content.</summary>
	public bool bMature;
	///<summary>If set to true will disable automatic generation of line breaks - use if the subtitles have been split manually.</summary>
	public bool bManualWordWrap;
	///<summary>If set to true the subtitles display as a sequence of single lines as opposed to multiline.</summary>
	public bool bSingleLine;
	///<summary>bVirtualizeWhenSilent_DEPRECATED</summary>
	public bool bVirtualizeWhenSilent_DEPRECATED;
	///<summary>Whether or not this source is ambisonics file format. If set, sound always uses the</summary>
	public bool bIsAmbisonics;
	///<summary>Specifies how and when compressed audio data is loaded for asset if stream caching is enabled.</summary>
	public ESoundWaveLoadingBehavior LoadingBehavior;
	///<summary>A localized version of the text that is actually spoken phonetically in the audio.</summary>
	public string SpokenText_DEPRECATED;
	///<summary>The priority of the subtitle.</summary>
	public float SubtitlePriority;
	///<summary>Playback volume of sound 0 to 1 - Default is 1.0.</summary>
	public float Volume;
	///<summary>Playback pitch for sound.</summary>
	public float Pitch;
	///<summary>Number of channels of multichannel data; 1 or 2 for regular mono and stereo files</summary>
	public int NumChannels;
	///<summary>Cue point data parsed fro the .wav file. Contains &quot;Loop Regions&quot; as cue points as well!</summary>
	public TArray<FSoundWaveCuePoint> CuePoints;
	///<summary>Offsets into the bulk data for the source wav data</summary>
	public TArray<int> ChannelOffsets;
	///<summary>Sizes of the bulk data for the source wav data</summary>
	public TArray<int> ChannelSizes;
	///<summary>Cooked sample rate of the asset. Can be modified by sample rate override.</summary>
	public int SampleRate;
	///<summary>Sample rate of the imported sound wave.</summary>
	public int ImportedSampleRate;
	///<summary>Subtitle cues.</summary>
	public TArray<FSubtitleCue> Subtitles;
	///<summary>Provides contextual information for the sound to the translator.</summary>
	public string Comment;
	///<summary>Information about the time-code from import, if available.</summary>
	public FSoundWaveTimecodeInfo TimecodeInfo;
	///<summary>SourceFilePath_DEPRECATED</summary>
	public string SourceFilePath_DEPRECATED;
	///<summary>SourceFileTimestamp_DEPRECATED</summary>
	public string SourceFileTimestamp_DEPRECATED;
	///<summary>AssetImportData</summary>
	public UAssetImportData AssetImportData;
	///<summary>Curves associated with this sound wave</summary>
	public UCurveTable Curves;
	///<summary>Hold a reference to our internal curve so we can switch back to it if we want to</summary>
	public UCurveTable InternalCurves;
	///<summary>Waveform edits to be applied to this SoundWave on cook (editing transformations will trigger a cook)</summary>
	public TArray<UWaveformTransformationBase> Transformations;
}
