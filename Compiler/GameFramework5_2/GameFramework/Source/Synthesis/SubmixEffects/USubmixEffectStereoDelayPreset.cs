namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USubmixEffectDelayPreset</summary>
[CppInclude("SubmixEffects/SubmixEffectStereoDelay.h")]
public partial class USubmixEffectStereoDelayPreset : USoundEffectSubmixPreset {
	public static UClass StaticClass() {return default;}
	///<summary>Set all tap delay settings. This will replace any dynamically added or modified taps.</summary>
	public void SetSettings(FSubmixEffectStereoDelaySettings InSettings) {}
	///<summary>Settings</summary>
	public FSubmixEffectStereoDelaySettings Settings;
}
