#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SynthComponent.h")]
public partial class USynthComponent : USceneComponent {
// SynthComponent
	public void Start() {}
	public void Stop() {}
	public bool IsPlaying() { return default; }
	public void SetVolumeMultiplier(float VolumeMultiplier) {}
	public void SetSubmixSend(UObject Submix,float SendLevel) {}
	public void SetLowPassFilterEnabled(bool InLowPassFilterEnabled) {}
	public void SetLowPassFilterFrequency(float InLowPassFilterFrequency) {}
	public void SetOutputToBusOnly(bool bInOutputToBusOnly) {}
	public void FadeIn(float FadeInDuration,float FadeVolumeLevel/*=1.0f*/,float StartTime/*=0.0f*/,EAudioFaderCurve FadeCurve/*=EAudioFaderCurve.Linear*/) {}
	public void FadeOut(float FadeOutDuration,float FadeVolumeLevel,EAudioFaderCurve FadeCurve/*=EAudioFaderCurve.Linear*/) {}
	public void AdjustVolume(float AdjustVolumeDuration,float AdjustVolumeLevel,EAudioFaderCurve FadeCurve/*=EAudioFaderCurve.Linear*/) {}
	public bool bAutoDestroy;
	public bool bStopWhenOwnerDestroyed;
	public bool bAllowSpatialization;
	public bool bOverrideAttenuation;
	public bool bOutputToBusOnly_DEPRECATED;
	public bool bEnableBusSends;
	public bool bEnableBaseSubmix;
	public bool bEnableSubmixSends;
	public USoundAttenuation AttenuationSettings;
	public FSoundAttenuationSettings AttenuationOverrides;
	public USoundConcurrency ConcurrencySettings_DEPRECATED;
	public TSet<USoundConcurrency> ConcurrencySet;
	public USoundClass SoundClass;
	public USoundEffectSourcePresetChain SourceEffectChain;
	public USoundSubmixBase SoundSubmix;
	public TArray<FSoundSubmixSendInfo> SoundSubmixSends;
	public TArray<FSoundSourceBusSendInfo> BusSends;
	public TArray<FSoundSourceBusSendInfo> PreEffectBusSends;
	public bool bIsUISound;
	public bool bIsPreviewSound;
	public int EnvelopeFollowerAttackTime;
	public int EnvelopeFollowerReleaseTime;
	public FOnSynthEnvelopeValue OnAudioEnvelopeValue;
	public USynthSound Synth;
	public UAudioComponent AudioComponent;
}
