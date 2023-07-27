#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ScrollBar.h")]
public partial class UScrollBar : UWidget {
// ScrollBar
	public FScrollBarStyle WidgetStyle;
	public bool bAlwaysShowScrollbar;
	public bool bAlwaysShowScrollbarTrack;
	public byte Orientation;
	public FVector2D Thickness;
	public FMargin Padding;
	public  void SetState(float InOffsetFraction,float InThumbSizeFraction) {}
}
