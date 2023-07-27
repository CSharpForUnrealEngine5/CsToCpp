#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/SubmixEffectDelay.h")]
///<summary>USubmixEffectDelayPreset</summary>
public partial class USubmixEffectDelayPreset : USoundEffectSubmixPreset {
// SubmixEffectDelayPreset
	public  void SetSettings(FSubmixEffectDelaySettings InSettings) {}
	public  void SetDefaultSettings(FSubmixEffectDelaySettings InSettings) {}
	public  float GetMaxDelayInMilliseconds() { return default; }
	public  void SetInterpolationTime(float Time) {}
	public  void SetDelay(float Length) {}
	public FSubmixEffectDelaySettings Settings;
	public FSubmixEffectDelaySettings DynamicSettings;
}
