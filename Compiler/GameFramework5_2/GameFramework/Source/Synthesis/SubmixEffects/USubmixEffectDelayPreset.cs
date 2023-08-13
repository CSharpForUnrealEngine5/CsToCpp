namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USubmixEffectDelayPreset</summary>
[CppInclude("SubmixEffects/SubmixEffectDelay.h")]
public partial class USubmixEffectDelayPreset : USoundEffectSubmixPreset {
	public static UClass StaticClass() {return default;}
	///<summary>Sets runtime delay settings. This will replace any dynamically added or modified settings without modifying</summary>
	public void SetSettings(FSubmixEffectDelaySettings InSettings) {}
	///<summary>Sets object&#39;s default settings. This will update both the default UObject settings (and mark it as dirty),</summary>
	public void SetDefaultSettings(FSubmixEffectDelaySettings InSettings) {}
	///<summary>Get the maximum delay possible.</summary>
	public float GetMaxDelayInMilliseconds() { return default; }
	///<summary>Set the time it takes to interpolate between parameters, in milliseconds.</summary>
	public void SetInterpolationTime(float Time) {}
	///<summary>Set how long the delay actually is, in milliseconds.</summary>
	public void SetDelay(float Length) {}
	///<summary>Settings</summary>
	public FSubmixEffectDelaySettings Settings;
	///<summary>DynamicSettings</summary>
	public FSubmixEffectDelaySettings DynamicSettings;
}
