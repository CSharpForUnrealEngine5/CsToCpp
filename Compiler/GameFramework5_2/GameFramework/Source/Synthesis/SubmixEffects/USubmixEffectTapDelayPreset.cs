#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTapDelaySubmixPreset</summary>
[CppInclude("SubmixEffects/SubmixEffectTapDelay.h")]
public partial class USubmixEffectTapDelayPreset : USoundEffectSubmixPreset {
	///<summary>Set all tap delay setting. This will replace any dynamically added or modified taps.</summary>
	public  void SetSettings(FSubmixEffectTapDelaySettings InSettings) {}
	///<summary>Adds a dynamic tap delay with the given settings. Returns the tap id.</summary>
	public  void AddTap(int TapId) {}
	///<summary>Remove the tap from the preset.</summary>
	public  void RemoveTap(int TapId) {}
	///<summary>Modify a specific tap.</summary>
	public  void SetTap(int TapId,FTapDelayInfo TapInfo) {}
	///<summary>Get the current info about a specific tap.</summary>
	public  void GetTap(int TapId,FTapDelayInfo TapInfo) {}
	///<summary>Retrieve an array of all tap ids for the submix effect.</summary>
	public  void GetTapIds(TArray<int> TapIds) {}
	///<summary>Get the maximum delay possible.</summary>
	public  float GetMaxDelayInMilliseconds() { return default; }
	///<summary>Set the time it takes to interpolate between parameters, in milliseconds.</summary>
	public  void SetInterpolationTime(float Time) {}
	///<summary>Settings</summary>
	public FSubmixEffectTapDelaySettings Settings;
}
