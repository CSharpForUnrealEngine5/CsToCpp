namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ScrollBar.h")]
public partial class UScrollBar : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Style of the scrollbar</summary>
	public FScrollBarStyle WidgetStyle;
	///<summary>bAlwaysShowScrollbar</summary>
	public bool bAlwaysShowScrollbar;
	///<summary>bAlwaysShowScrollbarTrack</summary>
	public bool bAlwaysShowScrollbarTrack;
	///<summary>Orientation</summary>
	public EOrientation Orientation;
	///<summary>The thickness of the scrollbar thumb</summary>
	public FVector2D Thickness;
	///<summary>The margin around the scrollbar</summary>
	public FMargin Padding;
	///<summary>Set the offset and size of the track&#39;s thumb.</summary>
	public void SetState(float InOffsetFraction,float InThumbSizeFraction) {}
}
