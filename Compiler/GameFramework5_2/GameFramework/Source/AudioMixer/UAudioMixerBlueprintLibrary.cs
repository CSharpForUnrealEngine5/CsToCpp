namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioMixerBlueprintLibrary.h")]
public partial class UAudioMixerBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the device info in a human readable format</summary>
	public static string Conv_AudioOutputDeviceInfoToString(FAudioOutputDeviceInfo Info) { return default; }
	///<summary>Adds a submix effect preset to the master submix.</summary>
	public static void AddMasterSubmixEffect(UObject WorldContextObject,USoundEffectSubmixPreset SubmixEffectPreset) {}
	///<summary>Removes a submix effect preset from the master submix.</summary>
	public static void RemoveMasterSubmixEffect(UObject WorldContextObject,USoundEffectSubmixPreset SubmixEffectPreset) {}
	///<summary>Clears all master submix effects.</summary>
	public static void ClearMasterSubmixEffects(UObject WorldContextObject) {}
	///<summary>Adds a submix effect preset to the given submix at the end of its submix effect chain. Returns the number of submix effects.</summary>
	public static int AddSubmixEffect(UObject WorldContextObject,USoundSubmix SoundSubmix,USoundEffectSubmixPreset SubmixEffectPreset) { return default; }
	///<summary>RemoveSubmixEffectPreset</summary>
	public static void RemoveSubmixEffectPreset(UObject WorldContextObject,USoundSubmix SoundSubmix,USoundEffectSubmixPreset SubmixEffectPreset) {}
	///<summary>Removes all instances of a submix effect preset from the given submix.</summary>
	public static void RemoveSubmixEffect(UObject WorldContextObject,USoundSubmix SoundSubmix,USoundEffectSubmixPreset SubmixEffectPreset) {}
	///<summary>RemoveSubmixEffectPresetAtIndex</summary>
	public static void RemoveSubmixEffectPresetAtIndex(UObject WorldContextObject,USoundSubmix SoundSubmix,int SubmixChainIndex) {}
	///<summary>Removes the submix effect at the given submix chain index, if there is a submix effect at that index.</summary>
	public static void RemoveSubmixEffectAtIndex(UObject WorldContextObject,USoundSubmix SoundSubmix,int SubmixChainIndex) {}
	///<summary>ReplaceSoundEffectSubmix</summary>
	public static void ReplaceSoundEffectSubmix(UObject WorldContextObject,USoundSubmix InSoundSubmix,int SubmixChainIndex,USoundEffectSubmixPreset SubmixEffectPreset) {}
	///<summary>Replaces the submix effect at the given submix chain index, adds the effect if there is none at that index.</summary>
	public static void ReplaceSubmixEffect(UObject WorldContextObject,USoundSubmix InSoundSubmix,int SubmixChainIndex,USoundEffectSubmixPreset SubmixEffectPreset) {}
	///<summary>Clears all submix effects on the given submix.</summary>
	public static void ClearSubmixEffects(UObject WorldContextObject,USoundSubmix SoundSubmix) {}
	///<summary>Sets a submix effect chain override on the given submix. The effect chain will cross fade from the base effect chain or current override to the new override.</summary>
	public static void SetSubmixEffectChainOverride(UObject WorldContextObject,USoundSubmix SoundSubmix,TArray<USoundEffectSubmixPreset> SubmixEffectPresetChain,float FadeTimeSec) {}
	///<summary>Clears all submix effect overrides on the given submix and returns it to the default effect chain.</summary>
	public static void ClearSubmixEffectChainOverride(UObject WorldContextObject,USoundSubmix SoundSubmix,float FadeTimeSec) {}
	///<summary>Start recording audio. By leaving the Submix To Record field blank, you can record the master output of the game.</summary>
	public static void StartRecordingOutput(UObject WorldContextObject,float ExpectedDuration,USoundSubmix SubmixToRecord/*=nullptr*/) {}
	///<summary>Stop recording audio. Path can be absolute, or relative (to the /Saved/BouncedWavFiles folder). By leaving the Submix To Record field blank, you can record the master output of the game.</summary>
	public static USoundWave StopRecordingOutput(UObject WorldContextObject,EAudioRecordingExportType ExportType,string Name,string Path,USoundSubmix SubmixToRecord/*=nullptr*/,USoundWave ExistingSoundWaveToOverwrite/*=nullptr*/) { return default; }
	///<summary>Pause recording audio, without finalizing the recording to disk. By leaving the Submix To Record field blank, you can record the master output of the game.</summary>
	public static void PauseRecordingOutput(UObject WorldContextObject,USoundSubmix SubmixToPause/*=nullptr*/) {}
	///<summary>Resume recording audio after pausing. By leaving the Submix To Pause field blank, you can record the master output of the game.</summary>
	public static void ResumeRecordingOutput(UObject WorldContextObject,USoundSubmix SubmixToPause/*=nullptr*/) {}
	///<summary>Start spectrum analysis of the audio output. By leaving the Submix To Analyze blank, you can analyze the master output of the game.</summary>
	public static void StartAnalyzingOutput(UObject WorldContextObject,USoundSubmix SubmixToAnalyze/*=nullptr*/,EFFTSize FFTSize/*=EFFTSize.DefaultSize*/,EFFTPeakInterpolationMethod InterpolationMethod/*=EFFTPeakInterpolationMethod.Linear*/,EFFTWindowType WindowType/*=EFFTWindowType.Hann*/,float HopSize/*=0f*/,EAudioSpectrumType SpectrumType/*=EAudioSpectrumType.MagnitudeSpectrum*/) {}
	///<summary>Stop spectrum analysis.</summary>
	public static void StopAnalyzingOutput(UObject WorldContextObject,USoundSubmix SubmixToStopAnalyzing/*=nullptr*/) {}
	///<summary>Make an array of musically spaced bands with ascending frequency.</summary>
	public static TArray<FSoundSubmixSpectralAnalysisBandSettings> MakeMusicalSpectralAnalysisBandSettings(int InNumSemitones/*=60*/,EMusicalNoteName InStartingMusicalNote/*=EMusicalNoteName.C*/,int InStartingOctave/*=2*/,int InAttackTimeMsec/*=10*/,int InReleaseTimeMsec/*=10*/) { return default; }
	///<summary>Make an array of logarithmically spaced bands.</summary>
	public static TArray<FSoundSubmixSpectralAnalysisBandSettings> MakeFullSpectrumSpectralAnalysisBandSettings(int InNumBands/*=30*/,float InMinimumFrequency/*=40.0f*/,float InMaximumFrequency/*=16000.0f*/,int InAttackTimeMsec/*=10*/,int InReleaseTimeMsec/*=10*/) { return default; }
	///<summary>Make an array of bands which span the frequency range of a given EAudioSpectrumBandPresetType.</summary>
	public static TArray<FSoundSubmixSpectralAnalysisBandSettings> MakePresetSpectralAnalysisBandSettings(EAudioSpectrumBandPresetType InBandPresetType,int InNumBands/*=10*/,int InAttackTimeMsec/*=10*/,int InReleaseTimeMsec/*=10*/) { return default; }
	///<summary>Retrieve the magnitudes for the given frequencies.</summary>
	public static void GetMagnitudeForFrequencies(UObject WorldContextObject,TArray<float> Frequencies,TArray<float> Magnitudes,USoundSubmix SubmixToAnalyze/*=nullptr*/) {}
	///<summary>Retrieve the phases for the given frequencies.</summary>
	public static void GetPhaseForFrequencies(UObject WorldContextObject,TArray<float> Frequencies,TArray<float> Phases,USoundSubmix SubmixToAnalyze/*=nullptr*/) {}
	///<summary>Adds source effect entry to preset chain. Only effects the instance of the preset chain</summary>
	public static void AddSourceEffectToPresetChain(UObject WorldContextObject,USoundEffectSourcePresetChain PresetChain,FSourceEffectChainEntry Entry) {}
	///<summary>Removes source effect entry from preset chain. Only affects the instance of preset chain.</summary>
	public static void RemoveSourceEffectFromPresetChain(UObject WorldContextObject,USoundEffectSourcePresetChain PresetChain,int EntryIndex) {}
	///<summary>Set whether or not to bypass the effect at the source effect chain index.</summary>
	public static void SetBypassSourceEffectChainEntry(UObject WorldContextObject,USoundEffectSourcePresetChain PresetChain,int EntryIndex,bool bBypassed) {}
	///<summary>Returns the number of effect chain entries in the given source effect chain.</summary>
	public static int GetNumberOfEntriesInSourceEffectChain(UObject WorldContextObject,USoundEffectSourcePresetChain PresetChain) { return default; }
	///<summary>Begin loading a sound into the cache so that it can be played immediately.</summary>
	public static void PrimeSoundForPlayback(USoundWave SoundWave,FOnSoundLoadComplete OnLoadCompletion) {}
	///<summary>Begin loading any sounds referenced by a sound cue into the cache so that it can be played immediately.</summary>
	public static void PrimeSoundCueForPlayback(USoundCue SoundCue) {}
	///<summary>Trim memory used by the audio cache. Returns the number of megabytes freed.</summary>
	public static float TrimAudioCache(float InMegabytesToFree) { return default; }
	///<summary>Starts the given audio bus.</summary>
	public static void StartAudioBus(UObject WorldContextObject,UAudioBus AudioBus) {}
	///<summary>Stops the given audio bus.</summary>
	public static void StopAudioBus(UObject WorldContextObject,UAudioBus AudioBus) {}
	///<summary>Queries if the given audio bus is active (and audio can be mixed to it).</summary>
	public static bool IsAudioBusActive(UObject WorldContextObject,UAudioBus AudioBus) { return default; }
	///<summary>Gets information about all audio output devices available in the system</summary>
	public static void GetAvailableAudioOutputDevices(UObject WorldContextObject,FOnAudioOutputDevicesObtained OnObtainDevicesEvent) {}
	///<summary>Gets information about the currently used audio output device</summary>
	public static void GetCurrentAudioOutputDeviceName(UObject WorldContextObject,FOnMainAudioOutputDeviceObtained OnObtainCurrentDeviceEvent) {}
	///<summary>Hotswaps to the requested audio output device</summary>
	public static void SwapAudioOutputDevice(UObject WorldContextObject,string NewDeviceId,FOnCompletedDeviceSwap OnCompletedDeviceSwap) {}
}
