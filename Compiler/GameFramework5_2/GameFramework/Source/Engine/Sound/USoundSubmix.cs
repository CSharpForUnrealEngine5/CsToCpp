#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sound Submix class meant for applying an effect to the downmixed sum of multiple audio sources.</summary>
[CppInclude("Sound/SoundSubmix.h")]
public partial class USoundSubmix : USoundSubmixWithParentBase {
	///<summary>Mute this submix when the application is muted or in the background. Used to prevent submix effect tails from continuing when tabbing out of application or if application is muted.</summary>
	public bool bMuteWhenBackgrounded;
	///<summary>SubmixEffectChain</summary>
	public TArray<USoundEffectSubmixPreset> SubmixEffectChain;
	///<summary>Optional settings used by plugins which support ambisonics file playback.</summary>
	public USoundfieldEncodingSettingsBase AmbisonicsPluginSettings;
	///<summary>The attack time in milliseconds for the envelope follower. Delegate callbacks can be registered to get the envelope value of sounds played with this submix.</summary>
	public int EnvelopeFollowerAttackTime;
	///<summary>The release time in milliseconds for the envelope follower. Delegate callbacks can be registered to get the envelope value of sounds played with this submix.</summary>
	public int EnvelopeFollowerReleaseTime;
	///<summary>Deprecated -- The output volume of the submix. Applied after submix effects and analysis are performed.</summary>
	public float OutputVolume;
	///<summary>Deprecated -- The wet level of the submix. Applied after submix effects and analysis are performed.</summary>
	public float WetLevel;
	///<summary>Deprecated -- The dry level of the submix. Applied before submix effects and analysis are performed.</summary>
	public float DryLevel;
	///<summary>The output volume of the submix in Decibels. Applied after submix effects and analysis are performed.</summary>
	public FSoundModulationDestinationSettings OutputVolumeModulation;
	///<summary>The wet level of the submixin Decibels. Applied after submix effects and analysis are performed.</summary>
	public FSoundModulationDestinationSettings WetLevelModulation;
	///<summary>The dry level of the submix in Decibels. Applied before submix effects and analysis are performed.</summary>
	public FSoundModulationDestinationSettings DryLevelModulation;
	///<summary>Whether to send this Submix to AudioLink (when AudioLink is Enabled)</summary>
	public bool bSendToAudioLink;
	///<summary>Optional Audio Link Settings Object</summary>
	public UAudioLinkSettingsAbstract AudioLinkSettings;
	///<summary>Blueprint delegate for when a recorded file is finished exporting.</summary>
	public FOnSubmixRecordedFileDone OnSubmixRecordedFileDone;
	///<summary>Start recording the audio from this submix.</summary>
	public  void StartRecordingOutput(UObject WorldContextObject,float ExpectedDuration) {}
	///<summary>Finish recording the audio from this submix and export it as a wav file or a USoundWave.</summary>
	public  void StopRecordingOutput(UObject WorldContextObject,EAudioRecordingExportType ExportType,string Name,string Path,USoundWave ExistingSoundWaveToOverwrite/*=nullptr*/) {}
	///<summary>Start envelope following the submix output. Register with OnSubmixEnvelope to receive envelope follower data in BP.</summary>
	public  void StartEnvelopeFollowing(UObject WorldContextObject) {}
	///<summary>Start envelope following the submix output. Register with OnSubmixEnvelope to receive envelope follower data in BP.</summary>
	public  void StopEnvelopeFollowing(UObject WorldContextObject) {}
	///<summary>Adds an envelope follower delegate to the submix when envelope following is enabled on this submix.</summary>
	public  void AddEnvelopeFollowerDelegate(UObject WorldContextObject,FOnSubmixEnvelopeBP OnSubmixEnvelopeBP) {}
	///<summary>Adds a spectral analysis delegate to receive notifications when this submix has spectrum analysis enabled.</summary>
	public  void AddSpectralAnalysisDelegate(UObject WorldContextObject,TArray<FSoundSubmixSpectralAnalysisBandSettings> InBandSettings,FOnSubmixSpectralAnalysisBP OnSubmixSpectralAnalysisBP,float UpdateRate/*=10.0f*/,float DecibelNoiseFloor/*=-40.0f*/,bool bDoNormalize/*=true*/,bool bDoAutoRange/*=false*/,float AutoRangeAttackTime/*=0.1f*/,float AutoRangeReleaseTime/*=60.0f*/) {}
	///<summary>Remove a spectral analysis delegate.</summary>
	public  void RemoveSpectralAnalysisDelegate(UObject WorldContextObject,FOnSubmixSpectralAnalysisBP OnSubmixSpectralAnalysisBP) {}
	///<summary>Start spectrum analysis of the audio output.</summary>
	public  void StartSpectralAnalysis(UObject WorldContextObject,EFFTSize FFTSize/*=EFFTSize.DefaultSize*/,EFFTPeakInterpolationMethod InterpolationMethod/*=EFFTPeakInterpolationMethod.Linear*/,EFFTWindowType WindowType/*=EFFTWindowType.Hann*/,float HopSize/*=0f*/,EAudioSpectrumType SpectrumType/*=EAudioSpectrumType.MagnitudeSpectrum*/) {}
	///<summary>Stop spectrum analysis of the audio output.</summary>
	public  void StopSpectralAnalysis(UObject WorldContextObject) {}
	///<summary>Sets the output volume of the submix in linear gain. This dynamic volume acts as a multiplier on the OutputVolume property of this submix.</summary>
	public  void SetSubmixOutputVolume(UObject WorldContextObject,float InOutputVolume) {}
	///<summary>Sets the output volume of the submix in linear gain. This dynamic level acts as a multiplier on the WetLevel property of this submix.</summary>
	public  void SetSubmixWetLevel(UObject WorldContextObject,float InWetLevel) {}
	///<summary>Sets the output volume of the submix in linear gain. This dynamic level acts as a multiplier on the DryLevel property of this submix.</summary>
	public  void SetSubmixDryLevel(UObject WorldContextObject,float InDryLevel) {}
}
