#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioMixerBlueprintLibrary.h")]
public partial class UAudioMixerBlueprintLibrary : UBlueprintFunctionLibrary {
// AudioMixerBlueprintLibrary
	public string Conv_AudioOutputDeviceInfoToString(FAudioOutputDeviceInfo Info) { return default; }
	public void AddMasterSubmixEffect(UObject WorldContextObject,UObject SubmixEffectPreset) {}
	public void RemoveMasterSubmixEffect(UObject WorldContextObject,UObject SubmixEffectPreset) {}
	public void ClearMasterSubmixEffects(UObject WorldContextObject) {}
	public int AddSubmixEffect(UObject WorldContextObject,UObject SoundSubmix,UObject SubmixEffectPreset) { return default; }
	public void RemoveSubmixEffectPreset(UObject WorldContextObject,UObject SoundSubmix,UObject SubmixEffectPreset) {}
	public void RemoveSubmixEffect(UObject WorldContextObject,UObject SoundSubmix,UObject SubmixEffectPreset) {}
	public void RemoveSubmixEffectPresetAtIndex(UObject WorldContextObject,UObject SoundSubmix,int SubmixChainIndex) {}
	public void RemoveSubmixEffectAtIndex(UObject WorldContextObject,UObject SoundSubmix,int SubmixChainIndex) {}
	public void ReplaceSoundEffectSubmix(UObject WorldContextObject,UObject InSoundSubmix,int SubmixChainIndex,UObject SubmixEffectPreset) {}
	public void ReplaceSubmixEffect(UObject WorldContextObject,UObject InSoundSubmix,int SubmixChainIndex,UObject SubmixEffectPreset) {}
	public void ClearSubmixEffects(UObject WorldContextObject,UObject SoundSubmix) {}
	public void SetSubmixEffectChainOverride(UObject WorldContextObject,UObject SoundSubmix,TArray<UObject> SubmixEffectPresetChain,float FadeTimeSec) {}
	public void ClearSubmixEffectChainOverride(UObject WorldContextObject,UObject SoundSubmix,float FadeTimeSec) {}
	public void StartRecordingOutput(UObject WorldContextObject,float ExpectedDuration,UObject SubmixToRecord/*=nullptr*/) {}
	public UObject StopRecordingOutput(UObject WorldContextObject,EAudioRecordingExportType ExportType,string Name,string Path,UObject SubmixToRecord/*=nullptr*/,UObject ExistingSoundWaveToOverwrite/*=nullptr*/) { return default; }
	public void PauseRecordingOutput(UObject WorldContextObject,UObject SubmixToPause/*=nullptr*/) {}
	public void ResumeRecordingOutput(UObject WorldContextObject,UObject SubmixToPause/*=nullptr*/) {}
	public void StartAnalyzingOutput(UObject WorldContextObject,UObject SubmixToAnalyze/*=nullptr*/,EFFTSize FFTSize/*=EFFTSize.DefaultSize*/,EFFTPeakInterpolationMethod InterpolationMethod/*=EFFTPeakInterpolationMethod.Linear*/,EFFTWindowType WindowType/*=EFFTWindowType.Hann*/,float HopSize/*=0f*/,EAudioSpectrumType SpectrumType/*=EAudioSpectrumType.MagnitudeSpectrum*/) {}
	public void StopAnalyzingOutput(UObject WorldContextObject,UObject SubmixToStopAnalyzing/*=nullptr*/) {}
	public TArray<FSoundSubmixSpectralAnalysisBandSettings> MakeMusicalSpectralAnalysisBandSettings(int InNumSemitones/*=60*/,EMusicalNoteName InStartingMusicalNote/*=EMusicalNoteName.C*/,int InStartingOctave/*=2*/,int InAttackTimeMsec/*=10*/,int InReleaseTimeMsec/*=10*/) { return default; }
	public TArray<FSoundSubmixSpectralAnalysisBandSettings> MakeFullSpectrumSpectralAnalysisBandSettings(int InNumBands/*=30*/,float InMinimumFrequency/*=40.0f*/,float InMaximumFrequency/*=16000.0f*/,int InAttackTimeMsec/*=10*/,int InReleaseTimeMsec/*=10*/) { return default; }
	public TArray<FSoundSubmixSpectralAnalysisBandSettings> MakePresetSpectralAnalysisBandSettings(EAudioSpectrumBandPresetType InBandPresetType,int InNumBands/*=10*/,int InAttackTimeMsec/*=10*/,int InReleaseTimeMsec/*=10*/) { return default; }
	public void GetMagnitudeForFrequencies(UObject WorldContextObject,TArray<float> Frequencies,TArray<float> Magnitudes,UObject SubmixToAnalyze/*=nullptr*/) {}
	public void GetPhaseForFrequencies(UObject WorldContextObject,TArray<float> Frequencies,TArray<float> Phases,UObject SubmixToAnalyze/*=nullptr*/) {}
	public void AddSourceEffectToPresetChain(UObject WorldContextObject,UObject PresetChain,FSourceEffectChainEntry Entry) {}
	public void RemoveSourceEffectFromPresetChain(UObject WorldContextObject,UObject PresetChain,int EntryIndex) {}
	public void SetBypassSourceEffectChainEntry(UObject WorldContextObject,UObject PresetChain,int EntryIndex,bool bBypassed) {}
	public int GetNumberOfEntriesInSourceEffectChain(UObject WorldContextObject,UObject PresetChain) { return default; }
	public void PrimeSoundForPlayback(UObject SoundWave,FOnSoundLoadComplete OnLoadCompletion) {}
	public void PrimeSoundCueForPlayback(UObject SoundCue) {}
	public float TrimAudioCache(float InMegabytesToFree) { return default; }
	public void StartAudioBus(UObject WorldContextObject,UObject AudioBus) {}
	public void StopAudioBus(UObject WorldContextObject,UObject AudioBus) {}
	public bool IsAudioBusActive(UObject WorldContextObject,UObject AudioBus) { return default; }
	public void GetAvailableAudioOutputDevices(UObject WorldContextObject,FOnAudioOutputDevicesObtained OnObtainDevicesEvent) {}
	public void GetCurrentAudioOutputDeviceName(UObject WorldContextObject,FOnMainAudioOutputDeviceObtained OnObtainCurrentDeviceEvent) {}
	public void SwapAudioOutputDevice(UObject WorldContextObject,string NewDeviceId,FOnCompletedDeviceSwap OnCompletedDeviceSwap) {}
}
