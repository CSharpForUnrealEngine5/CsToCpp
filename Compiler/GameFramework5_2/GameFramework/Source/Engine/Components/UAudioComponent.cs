#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/AudioComponent.h")]
///<summary>AudioComponent is used to play a Sound</summary>
public partial class UAudioComponent : USceneComponent {
// AudioComponent
	public USoundBase Sound;
	public TArray<FAudioParameter> DefaultParameters;
	public TArray<FAudioParameter> InstanceParameters;
	public USoundClass SoundClassOverride;
	public bool bAutoDestroy;
	public bool bStopWhenOwnerDestroyed;
	public bool bShouldRemainActiveIfDropped;
	public bool bAllowSpatialization;
	public bool bOverrideAttenuation;
	public bool bOverrideSubtitlePriority;
	public bool bIsUISound;
	public bool bEnableLowPassFilter;
	public bool bOverridePriority;
	public bool bSuppressSubtitles;
	public bool bCanPlayMultipleInstances;
	public bool bDisableParameterUpdatesWhilePlaying;
	public bool bAutoManageAttachment;
	public string AudioComponentUserID;
	public float PitchModulationMin;
	public float PitchModulationMax;
	public float VolumeModulationMin;
	public float VolumeModulationMax;
	public float VolumeMultiplier;
	public int EnvelopeFollowerAttackTime;
	public int EnvelopeFollowerReleaseTime;
	public float Priority;
	public float SubtitlePriority;
	public USoundEffectSourcePresetChain SourceEffectChain;
	public float VolumeWeightedPriorityScale_DEPRECATED;
	public float HighFrequencyGainMultiplier_DEPRECATED;
	public float PitchMultiplier;
	public float LowPassFilterFrequency;
	public USoundAttenuation AttenuationSettings;
	public FSoundAttenuationSettings AttenuationOverrides;
	public USoundConcurrency ConcurrencySettings_DEPRECATED;
	public TSet<USoundConcurrency> ConcurrencySet;
	public EAttachmentRule AutoAttachLocationRule;
	public EAttachmentRule AutoAttachRotationRule;
	public EAttachmentRule AutoAttachScaleRule;
	public FSoundModulationDefaultRoutingSettings ModulationRouting;
	public FOnAudioPlayStateChanged OnAudioPlayStateChanged;
	public FOnAudioVirtualizationChanged OnAudioVirtualizationChanged;
	public FOnAudioFinished OnAudioFinished;
	public FOnAudioPlaybackPercent OnAudioPlaybackPercent;
	public FOnAudioSingleEnvelopeValue OnAudioSingleEnvelopeValue;
	public FOnAudioMultiEnvelopeValue OnAudioMultiEnvelopeValue;
	public FOnQueueSubtitles OnQueueSubtitles;
	public void SetSound(UObject NewSound) {}
	public void FadeIn(float FadeInDuration,float FadeVolumeLevel/*=1.0f*/,float StartTime/*=0.0f*/,EAudioFaderCurve FadeCurve/*=EAudioFaderCurve.Linear*/) {}
	public void FadeOut(float FadeOutDuration,float FadeVolumeLevel,EAudioFaderCurve FadeCurve/*=EAudioFaderCurve.Linear*/) {}
	public void Play(float StartTime/*=0.0f*/) {}
	public void PlayQuantized(UObject WorldContextObject,UObject InClockHandle,FQuartzQuantizationBoundary InQuantizationBoundary,FOnQuartzCommandEventBP InDelegate,float InStartTime/*=0.0f*/,float InFadeInDuration/*=0.0f*/,float InFadeVolumeLevel/*=1.0f*/,EAudioFaderCurve InFadeCurve/*=EAudioFaderCurve.Linear*/) {}
	public void SetBoolParameter(string InName,bool InBool) {}
	public void SetIntParameter(string InName,int InInt) {}
	public void SetFloatParameter(string InName,float InFloat) {}
	public void Stop() {}
	public void StopDelayed(float DelayTime) {}
	public void SetPaused(bool bPause) {}
	public bool IsPlaying() { return default; }
	public bool IsVirtualized() { return default; }
	public EAudioComponentPlayState GetPlayState() { return default; }
	public void AdjustVolume(float AdjustVolumeDuration,float AdjustVolumeLevel,EAudioFaderCurve FadeCurve/*=EAudioFaderCurve.Linear*/) {}
	public void SetWaveParameter(string InName,UObject InWave) {}
	public void SetVolumeMultiplier(float NewVolumeMultiplier) {}
	public void SetPitchMultiplier(float NewPitchMultiplier) {}
	public void SetUISound(bool bInUISound) {}
	public void AdjustAttenuation(FSoundAttenuationSettings InAttenuationSettings) {}
	public void SetSubmixSend(UObject Submix,float SendLevel) {}
	public void SetSourceBusSendPreEffect(UObject SoundSourceBus,float SourceBusSendLevel) {}
	public void SetSourceBusSendPostEffect(UObject SoundSourceBus,float SourceBusSendLevel) {}
	public void SetAudioBusSendPreEffect(UObject AudioBus,float AudioBusSendLevel) {}
	public void SetAudioBusSendPostEffect(UObject AudioBus,float AudioBusSendLevel) {}
	public void SetLowPassFilterEnabled(bool InLowPassFilterEnabled) {}
	public void SetLowPassFilterFrequency(float InLowPassFilterFrequency) {}
	public void SetOutputToBusOnly(bool bInOutputToBusOnly) {}
	public bool HasCookedFFTData() { return default; }
	public bool HasCookedAmplitudeEnvelopeData() { return default; }
	public bool GetCookedFFTData(TArray<float> FrequenciesToGet,TArray<FSoundWaveSpectralData> OutSoundWaveSpectralData) { return default; }
	public bool GetCookedFFTDataForAllPlayingSounds(TArray<FSoundWaveSpectralDataPerSound> OutSoundWaveSpectralData) { return default; }
	public bool GetCookedEnvelopeData(float OutEnvelopeData) { return default; }
	public bool GetCookedEnvelopeDataForAllPlayingSounds(TArray<FSoundWaveEnvelopeDataPerSound> OutEnvelopeData) { return default; }
	public void SetModulationRouting(TSet<UObject> Modulators,EModulationDestination Destination,EModulationRouting RoutingMethod/*=EModulationRouting.Inherit*/) {}
	public TSet<UObject> GetModulators(EModulationDestination Destination) { return default; }
	public bool BP_GetAttenuationSettingsToApply(FSoundAttenuationSettings OutAttenuationSettings) { return default; }
	public TWeakObjectPtr<USceneComponent> AutoAttachParent;
	public string AutoAttachSocketName;
}
