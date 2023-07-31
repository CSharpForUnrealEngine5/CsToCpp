#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/SubmixEffectTapDelay.h")]
public partial struct FTapDelayInfo {
	public ETapLineMode TapLineMode;
	public float DelayLength;
	public float Gain;
	public int OutputChannel;
	public float PanInDegrees;
	public int TapId;
}
