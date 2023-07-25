#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundClass.h")]
public partial struct FSoundClassProperties {
// SoundClassProperties
	public float Volume;
	public float Pitch;
	public float LowPassFilterFrequency;
	public float AttenuationDistanceScale;
	public float LFEBleed;
	public float VoiceCenterChannelVolume;
	public float RadioFilterVolume;
	public float RadioFilterVolumeThreshold;
	public bool bApplyEffects;
	public bool bAlwaysPlay;
	public bool bIsUISound;
	public bool bIsMusic;
	public bool bCenterChannelOnly;
	public bool bApplyAmbientVolumes;
	public bool bReverb;
	public float Default2DReverbSendAmount;
	public FSoundModulationDefaultSettings ModulationSettings;
	public byte OutputTarget;
	public ESoundWaveLoadingBehavior LoadingBehavior;
	public USoundSubmix DefaultSubmix;
}
