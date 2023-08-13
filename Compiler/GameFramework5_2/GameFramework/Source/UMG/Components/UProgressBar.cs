namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The progress bar widget is a simple bar that fills up that can be restyled to fit any number of uses.</summary>
[CppInclude("Components/ProgressBar.h")]
public partial class UProgressBar : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The progress bar style</summary>
	public FProgressBarStyle WidgetStyle;
	///<summary>Used to determine the fill position of the progress bar ranging 0..1</summary>
	public float Percent;
	///<summary>Defines the direction in which the progress bar fills</summary>
	public EProgressBarFillType BarFillType;
	///<summary>Defines the visual style of the progress bar fill - scale or mask</summary>
	public EProgressBarFillStyle BarFillStyle;
	///<summary>bIsMarquee</summary>
	public bool bIsMarquee;
	///<summary>BorderPadding</summary>
	public FVector2D BorderPadding;
	///<summary>A bindable delegate to allow logic to drive the text of the widget</summary>
	public FGetFloat PercentDelegate;
	///<summary>Fill Color and Opacity</summary>
	public FLinearColor FillColorAndOpacity;
	///<summary>FillColorAndOpacityDelegate</summary>
	public FGetLinearColor FillColorAndOpacityDelegate;
	///<summary>Sets the current value of the ProgressBar.</summary>
	public void SetPercent(float InPercent) {}
	///<summary>Sets the progress bar to show as a marquee.</summary>
	public void SetIsMarquee(bool InbIsMarquee) {}
	///<summary>Sets the fill color of the progress bar.</summary>
	public void SetFillColorAndOpacity(FLinearColor InColor) {}
}
