#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkDebuggerSettings.h")]
public partial class ULiveLinkDebuggerSettings : UObject {
// LiveLinkDebuggerSettings
	public FSlateColor MinBarColor;
	public FSlateColor MaxBarColor;
	public float DPIScaleMultiplier;
	public  float GetDPIScaleBasedOnSize(FIntPoint Size) { return default; }
	public  FSlateColor GetBarColorForCurveValue(float CurveValue) { return default; }
}
