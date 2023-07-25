#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ListView.h")]
///<summary>A virtualized list that allows up to thousands of items to be displayed.</summary>
public partial class UListView : UListViewBase {
// ListView
	public TArray<UObject> GetListItems() { return default; }
	public void AddItem(UObject Item) {}
	public void RemoveItem(UObject Item) {}
	public UObject GetItemAt(int Index) { return default; }
	public int GetNumItems() { return default; }
	public int GetIndexForItem(UObject Item) { return default; }
	public void ClearListItems() {}
	public void SetSelectionMode(byte SelectionMode) {}
	public bool IsRefreshPending() { return default; }
	public void ScrollIndexIntoView(int Index) {}
	public void SetSelectedIndex(int Index) {}
	public void NavigateToIndex(int Index) {}
	public void OnListItemEndPlayed(UObject Item,EEndPlayReason EndPlayReason) {}
	public void OnListItemOuterEndPlayed(UObject ItemOuter,EEndPlayReason EndPlayReason) {}
	public FTableViewStyle WidgetStyle;
	public FScrollBarStyle ScrollBarStyle;
	public byte Orientation;
	public byte SelectionMode;
	public EConsumeMouseWheel ConsumeMouseWheel;
	public bool bClearSelectionOnClick;
	public bool bIsFocusable;
	public float EntrySpacing;
	public bool bReturnFocusToSelection;
	public TArray<UObject> ListItems;
	public void BP_SetSelectedItem(UObject Item) {}
	public void BP_SetItemSelection(UObject Item,bool bSelected) {}
	public void BP_ClearSelection() {}
	public int BP_GetNumItemsSelected() { return default; }
	public bool BP_GetSelectedItems(TArray<UObject> Items) { return default; }
	public bool BP_IsItemVisible(UObject Item) { return default; }
	public void BP_NavigateToItem(UObject Item) {}
	public void BP_ScrollItemIntoView(UObject Item) {}
	public void BP_CancelScrollIntoView() {}
	public void BP_SetListItems(TArray<UObject> InListItems) {}
	public UObject BP_GetSelectedItem() { return default; }
	public FOnListEntryInitializedDynamic BP_OnEntryInitialized;
	public FSimpleListItemEventDynamic BP_OnItemClicked;
	public FSimpleListItemEventDynamic BP_OnItemDoubleClicked;
	public FOnItemIsHoveredChangedDynamic BP_OnItemIsHoveredChanged;
	public FOnListItemSelectionChangedDynamic BP_OnItemSelectionChanged;
	public FOnListItemScrolledIntoViewDynamic BP_OnItemScrolledIntoView;
	public FOnListViewScrolledDynamic BP_OnListViewScrolled;
}
