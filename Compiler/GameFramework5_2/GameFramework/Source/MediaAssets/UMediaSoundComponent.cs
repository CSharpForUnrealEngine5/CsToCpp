#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a sound component for playing a media player&#39;s audio output.</summary>
[CppInclude("MediaSoundComponent.h")]
public partial class UMediaSoundComponent : USynthComponent {
	///<summary>Media sound channel type.</summary>
	public EMediaSoundChannels Channels;
	///<summary>Dynamically adjust the sample rate if audio and media clock desynchronize.</summary>
	public bool DynamicRateAdjustment;
	///<summary>Factor for calculating the sample rate adjustment.</summary>
	public float RateAdjustmentFactor;
	///<summary>The allowed range of dynamic rate adjustment.</summary>
	public FFloatRange RateAdjustmentRange;
	///<summary>Get the attenuation settings based on the current component settings.</summary>
	public  bool BP_GetAttenuationSettingsToApply(FSoundAttenuationSettings OutAttenuationSettings) { return default; }
	///<summary>Get the media player that provides the audio samples.</summary>
	public  UMediaPlayer GetMediaPlayer() { return default; }
	///<summary>Set the media player that provides the audio samples.</summary>
	public  void SetMediaPlayer(UMediaPlayer NewMediaPlayer) {}
	///<summary>Turns on spectral analysis of the audio generated in the media sound component.</summary>
	public  void SetEnableSpectralAnalysis(bool bInSpectralAnalysisEnabled) {}
	///<summary>Sets the settings to use for spectral analysis.</summary>
	public  void SetSpectralAnalysisSettings(TArray<float> InFrequenciesToAnalyze,EMediaSoundComponentFFTSize InFFTSize/*=EMediaSoundComponentFFTSize.Medium_512*/) {}
	///<summary>Retrieves the spectral data if spectral analysis is enabled.</summary>
	public  TArray<FMediaSoundComponentSpectralData> GetSpectralData() { return default; }
	///<summary>Retrieves and normalizes the spectral data if spectral analysis is enabled.</summary>
	public  TArray<FMediaSoundComponentSpectralData> GetNormalizedSpectralData() { return default; }
	///<summary>Turns on amplitude envelope following the audio in the media sound component.</summary>
	public  void SetEnableEnvelopeFollowing(bool bInEnvelopeFollowing) {}
	///<summary>Sets the envelope attack and release times (in ms).</summary>
	public  void SetEnvelopeFollowingsettings(int AttackTimeMsec,int ReleaseTimeMsec) {}
	///<summary>Retrieves the current amplitude envelope.</summary>
	public  float GetEnvelopeValue() { return default; }
	///<summary>The media player asset associated with this component.</summary>
	public UMediaPlayer MediaPlayer;
}
