#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USubmixEffectDelayPreset</summary>
[CppInclude("SubmixEffects/SubmixEffectStereoDelay.h")]
public partial class USubmixEffectStereoDelayPreset : USoundEffectSubmixPreset {
	///<summary>Set all tap delay settings. This will replace any dynamically added or modified taps.</summary>
	public  void SetSettings(FSubmixEffectStereoDelaySettings InSettings) {}
	///<summary>Settings</summary>
	public FSubmixEffectStereoDelaySettings Settings;
}
