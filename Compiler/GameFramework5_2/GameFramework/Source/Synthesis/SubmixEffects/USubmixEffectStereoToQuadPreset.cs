namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Submix effect which sends stereo audio to quad (left surround and right surround) if the channel count is greater than 2.</summary>
[CppInclude("SubmixEffects/SubmixEffectStereoToQuad.h")]
public partial class USubmixEffectStereoToQuadPreset : USoundEffectSubmixPreset {
	public static UClass StaticClass() {return default;}
	///<summary>Set all tap delay settings. This will replace any dynamically added or modified taps.</summary>
	public void SetSettings(FSubmixEffectStereoToQuadSettings InSettings) {}
	///<summary>Settings</summary>
	public FSubmixEffectStereoToQuadSettings Settings;
}
