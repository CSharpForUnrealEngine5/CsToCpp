#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ScrollBox.h")]
///<summary>An arbitrary scrollable collection of widgets.  Great for presenting 10-100 widgets in a list.  Doesn't support virtualization.</summary>
public partial class UScrollBox : UPanelWidget {
// ScrollBox
	public FScrollBoxStyle WidgetStyle;
	public FScrollBarStyle WidgetBarStyle;
	public byte Orientation;
	public ESlateVisibility ScrollBarVisibility;
	public EConsumeMouseWheel ConsumeMouseWheel;
	public FVector2D ScrollbarThickness;
	public FMargin ScrollbarPadding;
	public bool AlwaysShowScrollbar;
	public bool AlwaysShowScrollbarTrack;
	public bool AllowOverscroll;
	public bool BackPadScrolling;
	public bool FrontPadScrolling;
	public bool bAnimateWheelScrolling;
	public EDescendantScrollDestination NavigationDestination;
	public float NavigationScrollPadding;
	public EScrollWhenFocusChanges ScrollWhenFocusChanges;
	public bool bAllowRightClickDragScrolling;
	public float WheelScrollMultiplier;
	public void SetConsumeMouseWheel(EConsumeMouseWheel NewConsumeMouseWheel) {}
	public void SetOrientation(EOrientation NewOrientation) {}
	public void SetScrollBarVisibility(ESlateVisibility NewScrollBarVisibility) {}
	public void SetScrollbarThickness(FVector2D NewScrollbarThickness) {}
	public void SetScrollbarPadding(FMargin NewScrollbarPadding) {}
	public void SetAlwaysShowScrollbar(bool NewAlwaysShowScrollbar) {}
	public void SetAllowOverscroll(bool NewAllowOverscroll) {}
	public void SetAnimateWheelScrolling(bool bShouldAnimateWheelScrolling) {}
	public void SetWheelScrollMultiplier(float NewWheelScrollMultiplier) {}
	public void SetScrollWhenFocusChanges(EScrollWhenFocusChanges NewScrollWhenFocusChanges) {}
	public void SetNavigationDestination(EDescendantScrollDestination NewNavigationDestination) {}
	public void EndInertialScrolling() {}
	public FOnUserScrolledEvent OnUserScrolled;
	public void SetScrollOffset(float NewScrollOffset) {}
	public float GetScrollOffset() { return default; }
	public float GetScrollOffsetOfEnd() { return default; }
	public float GetViewFraction() { return default; }
	public float GetViewOffsetFraction() { return default; }
	public void ScrollToStart() {}
	public void ScrollToEnd() {}
	public void ScrollWidgetIntoView(UObject WidgetToFind,bool AnimateScroll/*=true*/,EDescendantScrollDestination ScrollDestination/*=EDescendantScrollDestination.IntoView*/,float Padding/*=0f*/) {}
}
