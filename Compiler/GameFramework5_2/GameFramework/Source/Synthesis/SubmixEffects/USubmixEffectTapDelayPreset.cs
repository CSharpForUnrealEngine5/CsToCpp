#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/SubmixEffectTapDelay.h")]
///<summary>UTapDelaySubmixPreset</summary>
public partial class USubmixEffectTapDelayPreset : USoundEffectSubmixPreset {
// SubmixEffectTapDelayPreset
	public void SetSettings(FSubmixEffectTapDelaySettings InSettings) {}
	public void AddTap(int TapId) {}
	public void RemoveTap(int TapId) {}
	public void SetTap(int TapId,FTapDelayInfo TapInfo) {}
	public void GetTap(int TapId,FTapDelayInfo TapInfo) {}
	public void GetTapIds(TArray<int> TapIds) {}
	public float GetMaxDelayInMilliseconds() { return default; }
	public void SetInterpolationTime(float Time) {}
	public FSubmixEffectTapDelaySettings Settings;
}
