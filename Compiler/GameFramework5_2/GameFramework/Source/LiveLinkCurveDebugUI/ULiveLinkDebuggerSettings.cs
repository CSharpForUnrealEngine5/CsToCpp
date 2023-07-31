#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkDebuggerSettings.h")]
public partial class ULiveLinkDebuggerSettings : UObject {
	///<summary>Color used when the CurveValue bar is at 0</summary>
	public FSlateColor MinBarColor;
	///<summary>Color used when the CurveValueBar is at 1.0</summary>
	public FSlateColor MaxBarColor;
	///<summary>This multiplier is used on the Viewport Widget version (IE: In Game) as it needs to be slightly more aggresive then the PC version</summary>
	public float DPIScaleMultiplier;
	///<summary>GetDPIScaleBasedOnSize</summary>
	public  float GetDPIScaleBasedOnSize(FIntPoint Size) { return default; }
	///<summary>GetBarColorForCurveValue</summary>
	public  FSlateColor GetBarColorForCurveValue(float CurveValue) { return default; }
}
