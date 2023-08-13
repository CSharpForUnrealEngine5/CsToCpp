namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Bare-bones base class to make creating custom UListView widgets easier.</summary>
[CppInclude("Components/ListViewBase.h")]
public partial class UListViewBase : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Gets all of the list entry widgets currently being displayed by the list</summary>
	public TArray<UUserWidget> GetDisplayedEntryWidgets() { return default; }
	///<summary>Get the scroll offset of this view (in items)</summary>
	public float GetScrollOffset() { return default; }
	///<summary>Full regeneration of all entries in the list. Note that the entry UWidget instances will not be destroyed, but they will be released and re-generated.</summary>
	public void RegenerateAllEntries() {}
	///<summary>Scroll the entire list up to the first item</summary>
	public void ScrollToTop() {}
	///<summary>Scroll the entire list down to the bottom-most item</summary>
	public void ScrollToBottom() {}
	///<summary>Set the scroll offset of this view (in items)</summary>
	public void SetScrollOffset(float InScrollOffset) {}
	///<summary>SetWheelScrollMultiplier</summary>
	public void SetWheelScrollMultiplier(float NewWheelScrollMultiplier) {}
	///<summary>SetScrollbarVisibility</summary>
	public void SetScrollbarVisibility(ESlateVisibility InVisibility) {}
	///<summary>Sets the list to refresh on the next tick.</summary>
	public void RequestRefresh() {}
	///<summary>Called when a row widget is generated for a list item</summary>
	public FOnListEntryGeneratedDynamic BP_OnEntryGenerated;
	///<summary>The type of widget to create for each entry displayed in the list.</summary>
	public UClass EntryWidgetClass;
	///<summary>The multiplier to apply when wheel scrolling</summary>
	public float WheelScrollMultiplier;
	///<summary>True to enable lerped animation when scrolling through the list</summary>
	public bool bEnableScrollAnimation;
	///<summary>Disable to stop scrollbars from activating inertial overscrolling</summary>
	public bool AllowOverscroll;
	///<summary>True to allow right click drag scrolling.</summary>
	public bool bEnableRightClickScrolling;
	///<summary>bEnableFixedLineOffset</summary>
	public bool bEnableFixedLineOffset;
	///<summary>Optional fixed offset (in lines) to always apply to the top/left (depending on orientation) of the list.</summary>
	public float FixedLineScrollOffset;
	///<summary>True to allow dragging of row widgets in the list</summary>
	public bool bAllowDragging;
	///<summary>Called when a row widget is released by the list (i.e. when it no longer represents a list item)</summary>
	public FOnListEntryReleasedDynamic BP_OnEntryReleased;
	///<summary>The number of dummy item entry widgets to preview in the widget designer</summary>
	public int NumDesignerPreviewEntries;
	///<summary>EntryWidgetPool</summary>
	public FUserWidgetPool EntryWidgetPool;
}
