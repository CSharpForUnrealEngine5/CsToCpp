#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ProgressBar.h")]
///<summary>The progress bar widget is a simple bar that fills up that can be restyled to fit any number of uses.</summary>
public partial class UProgressBar : UWidget {
// ProgressBar
	public FProgressBarStyle WidgetStyle;
	public float Percent;
	public byte BarFillType;
	public byte BarFillStyle;
	public bool bIsMarquee;
	public FVector2D BorderPadding;
	public FGetFloat PercentDelegate;
	public FLinearColor FillColorAndOpacity;
	public FGetLinearColor FillColorAndOpacityDelegate;
	public  void SetPercent(float InPercent) {}
	public  void SetIsMarquee(bool InbIsMarquee) {}
	public  void SetFillColorAndOpacity(FLinearColor InColor) {}
}
