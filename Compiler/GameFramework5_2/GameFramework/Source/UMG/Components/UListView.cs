#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A virtualized list that allows up to thousands of items to be displayed.</summary>
[CppInclude("Components/ListView.h")]
public partial class UListView : UListViewBase {
	///<summary>Gets the list of all items in the list.</summary>
	public  TArray<UObject> GetListItems() { return default; }
	///<summary>Adds an the item to the list</summary>
	public  void AddItem(UObject Item) {}
	///<summary>Removes an the item from the list</summary>
	public  void RemoveItem(UObject Item) {}
	///<summary>Returns the item at the given index</summary>
	public  UObject GetItemAt(int Index) { return default; }
	///<summary>Returns the total number of items</summary>
	public  int GetNumItems() { return default; }
	///<summary>Returns the index that the specified item is at. Will return the first found, or -1 for not found</summary>
	public  int GetIndexForItem(UObject Item) { return default; }
	///<summary>Removes all items from the list</summary>
	public  void ClearListItems() {}
	///<summary>Sets the new selection mode, preserving the current selection where possible.</summary>
	public  void SetSelectionMode(ESelectionMode SelectionMode) {}
	///<summary>Returns true if a refresh is pending and the list will be rebuilt on the next tick</summary>
	public  bool IsRefreshPending() { return default; }
	///<summary>Requests that the item at the given index is scrolled into view</summary>
	public  void ScrollIndexIntoView(int Index) {}
	///<summary>Sets the item at the given index as the sole selected item.</summary>
	public  void SetSelectedIndex(int Index) {}
	///<summary>Requests that the item at the given index navigated to, scrolling it into view if needed.</summary>
	public  void NavigateToIndex(int Index) {}
	///<summary>OnListItemEndPlayed</summary>
	public  void OnListItemEndPlayed(AActor Item,EEndPlayReason EndPlayReason) {}
	///<summary>OnListItemOuterEndPlayed</summary>
	public  void OnListItemOuterEndPlayed(AActor ItemOuter,EEndPlayReason EndPlayReason) {}
	///<summary>WidgetStyle</summary>
	public FTableViewStyle WidgetStyle;
	///<summary>ScrollBarStyle</summary>
	public FScrollBarStyle ScrollBarStyle;
	///<summary>The scroll &amp; layout orientation of the list. ListView and TileView only.</summary>
	public EOrientation Orientation;
	///<summary>SelectionMode</summary>
	public ESelectionMode SelectionMode;
	///<summary>ConsumeMouseWheel</summary>
	public EConsumeMouseWheel ConsumeMouseWheel;
	///<summary>bClearSelectionOnClick</summary>
	public bool bClearSelectionOnClick;
	///<summary>bIsFocusable</summary>
	public bool bIsFocusable;
	///<summary>EntrySpacing</summary>
	public float EntrySpacing;
	///<summary>bReturnFocusToSelection</summary>
	public bool bReturnFocusToSelection;
	///<summary>ListItems</summary>
	public TArray<UObject> ListItems;
	///<summary>Sets the given item as the sole selected item.</summary>
	public  void BP_SetSelectedItem(UObject Item) {}
	///<summary>Sets whether the given item is selected.</summary>
	public  void BP_SetItemSelection(UObject Item,bool bSelected) {}
	///<summary>Clear selection</summary>
	public  void BP_ClearSelection() {}
	///<summary>Gets the number of items currently selected in the list</summary>
	public  int BP_GetNumItemsSelected() { return default; }
	///<summary>Gets a list of all the currently selected items</summary>
	public  bool BP_GetSelectedItems(TArray<UObject> Items) { return default; }
	///<summary>Gets whether the entry for the given object is currently visible in the list</summary>
	public  bool BP_IsItemVisible(UObject Item) { return default; }
	///<summary>Requests that the given item is navigated to, scrolling it into view if needed.</summary>
	public  void BP_NavigateToItem(UObject Item) {}
	///<summary>Requests that the given item is scrolled into view</summary>
	public  void BP_ScrollItemIntoView(UObject Item) {}
	///<summary>Cancels a previous request to scroll and item into view.</summary>
	public  void BP_CancelScrollIntoView() {}
	///<summary>Sets the array of objects to display rows for in the list</summary>
	public  void BP_SetListItems(TArray<UObject> InListItems) {}
	///<summary>Gets the first selected item, if any; recommended that you only use this for single selection lists.</summary>
	public  UObject BP_GetSelectedItem() { return default; }
	///<summary>Called when a row widget is generated for a list item</summary>
	public FOnListEntryInitializedDynamic BP_OnEntryInitialized;
	///<summary>BP_OnItemClicked</summary>
	public FSimpleListItemEventDynamic BP_OnItemClicked;
	///<summary>BP_OnItemDoubleClicked</summary>
	public FSimpleListItemEventDynamic BP_OnItemDoubleClicked;
	///<summary>BP_OnItemIsHoveredChanged</summary>
	public FOnItemIsHoveredChangedDynamic BP_OnItemIsHoveredChanged;
	///<summary>BP_OnItemSelectionChanged</summary>
	public FOnListItemSelectionChangedDynamic BP_OnItemSelectionChanged;
	///<summary>BP_OnItemScrolledIntoView</summary>
	public FOnListItemScrolledIntoViewDynamic BP_OnItemScrolledIntoView;
	///<summary>BP_OnListViewScrolled</summary>
	public FOnListViewScrolledDynamic BP_OnListViewScrolled;
}
