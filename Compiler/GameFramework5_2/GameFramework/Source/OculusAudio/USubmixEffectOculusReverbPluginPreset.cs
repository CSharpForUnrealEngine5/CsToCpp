namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusAudioReverb.h")]
public partial class USubmixEffectOculusReverbPluginPreset : USoundEffectSubmixPreset {
	public static UClass StaticClass() {return default;}
	///<summary>SetSettings</summary>
	public void SetSettings(FSubmixEffectOculusReverbPluginSettings InSettings) {}
	///<summary>Settings</summary>
	public FSubmixEffectOculusReverbPluginSettings Settings;
}
