#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/AudioMixerSubmixEffectReverb.h")]
public partial class USubmixEffectReverbPreset : USoundEffectSubmixPreset {
	public static UClass StaticClass() {return default;}
	///<summary>SetSettings</summary>
	public  void SetSettings(FSubmixEffectReverbSettings InSettings) {}
	///<summary>SetSettingsWithReverbEffect</summary>
	public  void SetSettingsWithReverbEffect(UReverbEffect InReverbEffect,float WetLevel,float DryLevel/*=0.0f*/) {}
	///<summary>Settings</summary>
	public FSubmixEffectReverbSettings Settings;
}
