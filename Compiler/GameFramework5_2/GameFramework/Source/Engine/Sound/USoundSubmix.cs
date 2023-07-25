#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundSubmix.h")]
///<summary>Sound Submix class meant for applying an effect to the downmixed sum of multiple audio sources.</summary>
public partial class USoundSubmix : USoundSubmixWithParentBase {
// SoundSubmix
	public bool bMuteWhenBackgrounded;
	public TArray<USoundEffectSubmixPreset> SubmixEffectChain;
	public USoundfieldEncodingSettingsBase AmbisonicsPluginSettings;
	public int EnvelopeFollowerAttackTime;
	public int EnvelopeFollowerReleaseTime;
	public float OutputVolume;
	public float WetLevel;
	public float DryLevel;
	public FSoundModulationDestinationSettings OutputVolumeModulation;
	public FSoundModulationDestinationSettings WetLevelModulation;
	public FSoundModulationDestinationSettings DryLevelModulation;
	public bool bSendToAudioLink;
	public UAudioLinkSettingsAbstract AudioLinkSettings;
	public FOnSubmixRecordedFileDone OnSubmixRecordedFileDone;
	public void StartRecordingOutput(UObject WorldContextObject,float ExpectedDuration) {}
	public void StopRecordingOutput(UObject WorldContextObject,EAudioRecordingExportType ExportType,string Name,string Path,UObject ExistingSoundWaveToOverwrite/*=nullptr*/) {}
	public void StartEnvelopeFollowing(UObject WorldContextObject) {}
	public void StopEnvelopeFollowing(UObject WorldContextObject) {}
	public void AddEnvelopeFollowerDelegate(UObject WorldContextObject,FOnSubmixEnvelopeBP OnSubmixEnvelopeBP) {}
	public void AddSpectralAnalysisDelegate(UObject WorldContextObject,TArray<FSoundSubmixSpectralAnalysisBandSettings> InBandSettings,FOnSubmixSpectralAnalysisBP OnSubmixSpectralAnalysisBP,float UpdateRate/*=10.0f*/,float DecibelNoiseFloor/*=-40.0f*/,bool bDoNormalize/*=true*/,bool bDoAutoRange/*=false*/,float AutoRangeAttackTime/*=0.1f*/,float AutoRangeReleaseTime/*=60.0f*/) {}
	public void RemoveSpectralAnalysisDelegate(UObject WorldContextObject,FOnSubmixSpectralAnalysisBP OnSubmixSpectralAnalysisBP) {}
	public void StartSpectralAnalysis(UObject WorldContextObject,EFFTSize FFTSize/*=EFFTSize.DefaultSize*/,EFFTPeakInterpolationMethod InterpolationMethod/*=EFFTPeakInterpolationMethod.Linear*/,EFFTWindowType WindowType/*=EFFTWindowType.Hann*/,float HopSize/*=0f*/,EAudioSpectrumType SpectrumType/*=EAudioSpectrumType.MagnitudeSpectrum*/) {}
	public void StopSpectralAnalysis(UObject WorldContextObject) {}
	public void SetSubmixOutputVolume(UObject WorldContextObject,float InOutputVolume) {}
	public void SetSubmixWetLevel(UObject WorldContextObject,float InWetLevel) {}
	public void SetSubmixDryLevel(UObject WorldContextObject,float InDryLevel) {}
}
