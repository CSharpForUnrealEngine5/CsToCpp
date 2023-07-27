#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioMixerBlueprintLibrary.h")]
public partial class UAudioMixerBlueprintLibrary : UBlueprintFunctionLibrary {
// AudioMixerBlueprintLibrary
	public static string Conv_AudioOutputDeviceInfoToString(FAudioOutputDeviceInfo Info) { return default; }
	public static void AddMasterSubmixEffect(UObject WorldContextObject,USoundEffectSubmixPreset SubmixEffectPreset) {}
	public static void RemoveMasterSubmixEffect(UObject WorldContextObject,USoundEffectSubmixPreset SubmixEffectPreset) {}
	public static void ClearMasterSubmixEffects(UObject WorldContextObject) {}
	public static int AddSubmixEffect(UObject WorldContextObject,USoundSubmix SoundSubmix,USoundEffectSubmixPreset SubmixEffectPreset) { return default; }
	public static void RemoveSubmixEffectPreset(UObject WorldContextObject,USoundSubmix SoundSubmix,USoundEffectSubmixPreset SubmixEffectPreset) {}
	public static void RemoveSubmixEffect(UObject WorldContextObject,USoundSubmix SoundSubmix,USoundEffectSubmixPreset SubmixEffectPreset) {}
	public static void RemoveSubmixEffectPresetAtIndex(UObject WorldContextObject,USoundSubmix SoundSubmix,int SubmixChainIndex) {}
	public static void RemoveSubmixEffectAtIndex(UObject WorldContextObject,USoundSubmix SoundSubmix,int SubmixChainIndex) {}
	public static void ReplaceSoundEffectSubmix(UObject WorldContextObject,USoundSubmix InSoundSubmix,int SubmixChainIndex,USoundEffectSubmixPreset SubmixEffectPreset) {}
	public static void ReplaceSubmixEffect(UObject WorldContextObject,USoundSubmix InSoundSubmix,int SubmixChainIndex,USoundEffectSubmixPreset SubmixEffectPreset) {}
	public static void ClearSubmixEffects(UObject WorldContextObject,USoundSubmix SoundSubmix) {}
	public static void SetSubmixEffectChainOverride(UObject WorldContextObject,USoundSubmix SoundSubmix,TArray<USoundEffectSubmixPreset> SubmixEffectPresetChain,float FadeTimeSec) {}
	public static void ClearSubmixEffectChainOverride(UObject WorldContextObject,USoundSubmix SoundSubmix,float FadeTimeSec) {}
	public static void StartRecordingOutput(UObject WorldContextObject,float ExpectedDuration,USoundSubmix SubmixToRecord/*=nullptr*/) {}
	public static USoundWave StopRecordingOutput(UObject WorldContextObject,EAudioRecordingExportType ExportType,string Name,string Path,USoundSubmix SubmixToRecord/*=nullptr*/,USoundWave ExistingSoundWaveToOverwrite/*=nullptr*/) { return default; }
	public static void PauseRecordingOutput(UObject WorldContextObject,USoundSubmix SubmixToPause/*=nullptr*/) {}
	public static void ResumeRecordingOutput(UObject WorldContextObject,USoundSubmix SubmixToPause/*=nullptr*/) {}
	public static void StartAnalyzingOutput(UObject WorldContextObject,USoundSubmix SubmixToAnalyze/*=nullptr*/,EFFTSize FFTSize/*=EFFTSize.DefaultSize*/,EFFTPeakInterpolationMethod InterpolationMethod/*=EFFTPeakInterpolationMethod.Linear*/,EFFTWindowType WindowType/*=EFFTWindowType.Hann*/,float HopSize/*=0f*/,EAudioSpectrumType SpectrumType/*=EAudioSpectrumType.MagnitudeSpectrum*/) {}
	public static void StopAnalyzingOutput(UObject WorldContextObject,USoundSubmix SubmixToStopAnalyzing/*=nullptr*/) {}
	public static TArray<FSoundSubmixSpectralAnalysisBandSettings> MakeMusicalSpectralAnalysisBandSettings(int InNumSemitones/*=60*/,EMusicalNoteName InStartingMusicalNote/*=EMusicalNoteName.C*/,int InStartingOctave/*=2*/,int InAttackTimeMsec/*=10*/,int InReleaseTimeMsec/*=10*/) { return default; }
	public static TArray<FSoundSubmixSpectralAnalysisBandSettings> MakeFullSpectrumSpectralAnalysisBandSettings(int InNumBands/*=30*/,float InMinimumFrequency/*=40.0f*/,float InMaximumFrequency/*=16000.0f*/,int InAttackTimeMsec/*=10*/,int InReleaseTimeMsec/*=10*/) { return default; }
	public static TArray<FSoundSubmixSpectralAnalysisBandSettings> MakePresetSpectralAnalysisBandSettings(EAudioSpectrumBandPresetType InBandPresetType,int InNumBands/*=10*/,int InAttackTimeMsec/*=10*/,int InReleaseTimeMsec/*=10*/) { return default; }
	public static void GetMagnitudeForFrequencies(UObject WorldContextObject,TArray<float> Frequencies,TArray<float> Magnitudes,USoundSubmix SubmixToAnalyze/*=nullptr*/) {}
	public static void GetPhaseForFrequencies(UObject WorldContextObject,TArray<float> Frequencies,TArray<float> Phases,USoundSubmix SubmixToAnalyze/*=nullptr*/) {}
	public static void AddSourceEffectToPresetChain(UObject WorldContextObject,USoundEffectSourcePresetChain PresetChain,FSourceEffectChainEntry Entry) {}
	public static void RemoveSourceEffectFromPresetChain(UObject WorldContextObject,USoundEffectSourcePresetChain PresetChain,int EntryIndex) {}
	public static void SetBypassSourceEffectChainEntry(UObject WorldContextObject,USoundEffectSourcePresetChain PresetChain,int EntryIndex,bool bBypassed) {}
	public static int GetNumberOfEntriesInSourceEffectChain(UObject WorldContextObject,USoundEffectSourcePresetChain PresetChain) { return default; }
	public static void PrimeSoundForPlayback(USoundWave SoundWave,FOnSoundLoadComplete OnLoadCompletion) {}
	public static void PrimeSoundCueForPlayback(USoundCue SoundCue) {}
	public static float TrimAudioCache(float InMegabytesToFree) { return default; }
	public static void StartAudioBus(UObject WorldContextObject,UAudioBus AudioBus) {}
	public static void StopAudioBus(UObject WorldContextObject,UAudioBus AudioBus) {}
	public static bool IsAudioBusActive(UObject WorldContextObject,UAudioBus AudioBus) { return default; }
	public static void GetAvailableAudioOutputDevices(UObject WorldContextObject,FOnAudioOutputDevicesObtained OnObtainDevicesEvent) {}
	public static void GetCurrentAudioOutputDeviceName(UObject WorldContextObject,FOnMainAudioOutputDeviceObtained OnObtainCurrentDeviceEvent) {}
	public static void SwapAudioOutputDevice(UObject WorldContextObject,string NewDeviceId,FOnCompletedDeviceSwap OnCompletedDeviceSwap) {}
}
