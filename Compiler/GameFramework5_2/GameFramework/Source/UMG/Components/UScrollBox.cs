namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An arbitrary scrollable collection of widgets.  Great for presenting 10-100 widgets in a list.  Doesn&#39;t support virtualization.</summary>
[CppInclude("Components/ScrollBox.h")]
public partial class UScrollBox : UPanelWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The style</summary>
	public FScrollBoxStyle WidgetStyle;
	///<summary>The bar style</summary>
	public FScrollBarStyle WidgetBarStyle;
	///<summary>The orientation of the scrolling and stacking in the box.</summary>
	public EOrientation Orientation;
	///<summary>Visibility</summary>
	public ESlateVisibility ScrollBarVisibility;
	///<summary>When mouse wheel events should be consumed.</summary>
	public EConsumeMouseWheel ConsumeMouseWheel;
	///<summary>The thickness of the scrollbar thumb</summary>
	public FVector2D ScrollbarThickness;
	///<summary>The margin around the scrollbar</summary>
	public FMargin ScrollbarPadding;
	///<summary>AlwaysShowScrollbar</summary>
	public bool AlwaysShowScrollbar;
	///<summary>AlwaysShowScrollbarTrack</summary>
	public bool AlwaysShowScrollbarTrack;
	///<summary>Disable to stop scrollbars from activating inertial overscrolling</summary>
	public bool AllowOverscroll;
	///<summary>Whether to back pad this scroll box, allowing user to scroll backward until child contents are no longer visible</summary>
	public bool BackPadScrolling;
	///<summary>Whether to front pad this scroll box, allowing user to scroll forward until child contents are no longer visible</summary>
	public bool FrontPadScrolling;
	///<summary>True to lerp smoothly when wheel scrolling along the scroll box</summary>
	public bool bAnimateWheelScrolling;
	///<summary>Sets where to scroll a widget to when using explicit navigation or if ScrollWhenFocusChanges is enabled</summary>
	public EDescendantScrollDestination NavigationDestination;
	///<summary>The amount of padding to ensure exists between the item being navigated to, at the edge of the</summary>
	public float NavigationScrollPadding;
	///<summary>Scroll behavior when user focus is given to a child widget</summary>
	public EScrollWhenFocusChanges ScrollWhenFocusChanges;
	///<summary>Option to disable right-click-drag scrolling</summary>
	public bool bAllowRightClickDragScrolling;
	///<summary>The multiplier to apply when wheel scrolling</summary>
	public float WheelScrollMultiplier;
	///<summary>SetConsumeMouseWheel</summary>
	public void SetConsumeMouseWheel(EConsumeMouseWheel NewConsumeMouseWheel) {}
	///<summary>SetOrientation</summary>
	public void SetOrientation(EOrientation NewOrientation) {}
	///<summary>SetScrollBarVisibility</summary>
	public void SetScrollBarVisibility(ESlateVisibility NewScrollBarVisibility) {}
	///<summary>SetScrollbarThickness</summary>
	public void SetScrollbarThickness(FVector2D NewScrollbarThickness) {}
	///<summary>SetScrollbarPadding</summary>
	public void SetScrollbarPadding(FMargin NewScrollbarPadding) {}
	///<summary>SetAlwaysShowScrollbar</summary>
	public void SetAlwaysShowScrollbar(bool NewAlwaysShowScrollbar) {}
	///<summary>SetAllowOverscroll</summary>
	public void SetAllowOverscroll(bool NewAllowOverscroll) {}
	///<summary>SetAnimateWheelScrolling</summary>
	public void SetAnimateWheelScrolling(bool bShouldAnimateWheelScrolling) {}
	///<summary>SetWheelScrollMultiplier</summary>
	public void SetWheelScrollMultiplier(float NewWheelScrollMultiplier) {}
	///<summary>SetScrollWhenFocusChanges</summary>
	public void SetScrollWhenFocusChanges(EScrollWhenFocusChanges NewScrollWhenFocusChanges) {}
	///<summary>SetNavigationDestination</summary>
	public void SetNavigationDestination(EDescendantScrollDestination NewNavigationDestination) {}
	///<summary>Instantly stops any inertial scrolling that is currently in progress</summary>
	public void EndInertialScrolling() {}
	///<summary>Called when the scroll has changed</summary>
	public FOnUserScrolledEvent OnUserScrolled;
	///<summary>Updates the scroll offset of the scrollbox.</summary>
	public void SetScrollOffset(float NewScrollOffset) {}
	///<summary>Gets the scroll offset of the scrollbox in Slate Units.</summary>
	public float GetScrollOffset() { return default; }
	///<summary>Gets the scroll offset of the bottom of the ScrollBox in Slate Units.</summary>
	public float GetScrollOffsetOfEnd() { return default; }
	///<summary>Gets the fraction currently visible in the scrollbox</summary>
	public float GetViewFraction() { return default; }
	///<summary>GetViewOffsetFraction</summary>
	public float GetViewOffsetFraction() { return default; }
	///<summary>Scrolls the ScrollBox to the top instantly</summary>
	public void ScrollToStart() {}
	///<summary>Scrolls the ScrollBox to the bottom instantly during the next layout pass.</summary>
	public void ScrollToEnd() {}
	///<summary>Scrolls the ScrollBox to the widget during the next layout pass.</summary>
	public void ScrollWidgetIntoView(UWidget WidgetToFind,bool AnimateScroll/*=true*/,EDescendantScrollDestination ScrollDestination/*=EDescendantScrollDestination.IntoView*/,float Padding/*=0f*/) {}
}
