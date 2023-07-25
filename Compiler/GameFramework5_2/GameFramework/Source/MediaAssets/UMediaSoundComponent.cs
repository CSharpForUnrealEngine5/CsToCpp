#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaSoundComponent.h")]
///<summary>Implements a sound component for playing a media player's audio output.</summary>
public partial class UMediaSoundComponent : USynthComponent {
// MediaSoundComponent
	public EMediaSoundChannels Channels;
	public bool DynamicRateAdjustment;
	public float RateAdjustmentFactor;
	public FFloatRange RateAdjustmentRange;
	public bool BP_GetAttenuationSettingsToApply(FSoundAttenuationSettings OutAttenuationSettings) { return default; }
	public UObject GetMediaPlayer() { return default; }
	public void SetMediaPlayer(UObject NewMediaPlayer) {}
	public void SetEnableSpectralAnalysis(bool bInSpectralAnalysisEnabled) {}
	public void SetSpectralAnalysisSettings(TArray<float> InFrequenciesToAnalyze,EMediaSoundComponentFFTSize InFFTSize/*=EMediaSoundComponentFFTSize.Medium_512*/) {}
	public TArray<FMediaSoundComponentSpectralData> GetSpectralData() { return default; }
	public TArray<FMediaSoundComponentSpectralData> GetNormalizedSpectralData() { return default; }
	public void SetEnableEnvelopeFollowing(bool bInEnvelopeFollowing) {}
	public void SetEnvelopeFollowingsettings(int AttackTimeMsec,int ReleaseTimeMsec) {}
	public float GetEnvelopeValue() { return default; }
	public UMediaPlayer MediaPlayer;
}
