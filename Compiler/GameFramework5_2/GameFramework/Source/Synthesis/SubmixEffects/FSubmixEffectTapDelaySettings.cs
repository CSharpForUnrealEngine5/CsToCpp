namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FTapDelaySubmixPresetSettings</summary>
[CppInclude("SubmixEffects/SubmixEffectTapDelay.h")]
public partial struct FSubmixEffectTapDelaySettings {
	public float MaximumDelayLength;
	public float InterpolationTime;
	public TArray<FTapDelayInfo> Taps;
}
