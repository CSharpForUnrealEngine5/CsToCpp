#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/AudioMixerSubmixEffectReverb.h")]
public partial class USubmixEffectReverbPreset : USoundEffectSubmixPreset {
// SubmixEffectReverbPreset
	public  void SetSettings(FSubmixEffectReverbSettings InSettings) {}
	public  void SetSettingsWithReverbEffect(UReverbEffect InReverbEffect,float WetLevel,float DryLevel/*=0.0f*/) {}
	public FSubmixEffectReverbSettings Settings;
}
