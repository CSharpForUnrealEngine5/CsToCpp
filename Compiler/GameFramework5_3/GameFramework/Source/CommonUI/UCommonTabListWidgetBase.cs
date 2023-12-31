namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for a list of selectable tabs that correspondingly activate and display an arbitrary widget in a linked switcher</summary>
[CppInclude("CommonTabListWidgetBase.h")]
public partial class UCommonTabListWidgetBase : UCommonUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Delegate broadcast when a new tab is selected.</summary>
	public void FOnTabSelected(FName TabId) {}
	///<summary>Broadcasts when a new tab is selected.</summary>
	public FOnTabSelected OnTabSelected;
	///<summary>Delegate broadcast when a new tab is created. Allows hook ups after creation.</summary>
	public void FOnTabButtonCreation(FName TabId,UCommonButtonBase TabButton) {}
	///<summary>Broadcasts when a new tab is created.</summary>
	public FOnTabButtonCreation OnTabButtonCreation;
	///<summary>Delegate broadcast when a tab is being removed. Allows clean ups after destruction.</summary>
	public void FOnTabButtonRemoval(FName TabId,UCommonButtonBase TabButton) {}
	///<summary>Broadcasts when a new tab is created.</summary>
	public FOnTabButtonRemoval OnTabButtonRemoval;
	///<summary>Delegate broadcast when the tab list has been rebuilt (after a new tab has been inserted rather than added to the end).</summary>
	public void FOnTabListRebuilt() {}
	///<summary>Broadcasts when the tab list has been rebuilt (after a new tab has been inserted rather than added to the end).</summary>
	public FOnTabListRebuilt OnTabListRebuilt;
	///<summary>@return The currently active (selected) tab</summary>
	public FName GetActiveTab() { return default; }
	///<summary>Establishes the activatable widget switcher instance that this tab list should interact with</summary>
	public virtual void SetLinkedSwitcher(UCommonAnimatedSwitcher CommonSwitcher) {}
	///<summary>@return The switcher that this tab list is associated with and manipulates</summary>
	public UCommonAnimatedSwitcher GetLinkedSwitcher() { return default; }
	///<summary>INDEX_NONE</summary>
	public bool RegisterTab(FName TabNameID,UClass ButtonWidgetType,UWidget ContentWidget,int TabIndex/*=-1*/) { return default; }
	///<summary>RemoveTab</summary>
	public bool RemoveTab(FName TabNameID) { return default; }
	///<summary>RemoveAllTabs</summary>
	public void RemoveAllTabs() {}
	///<summary>GetTabCount</summary>
	public int GetTabCount() { return default; }
	///<summary>Selects the tab registered under the provided name ID</summary>
	public bool SelectTabByID(FName TabNameID,bool bSuppressClickFeedback/*=false*/) { return default; }
	///<summary>GetSelectedTabId</summary>
	public FName GetSelectedTabId() { return default; }
	///<summary>GetTabIdAtIndex</summary>
	public FName GetTabIdAtIndex(int Index) { return default; }
	///<summary>Sets the visibility of the tab associated with the given ID</summary>
	public void SetTabVisibility(FName TabNameID,ESlateVisibility NewVisibility) {}
	///<summary>Sets whether the tab associated with the given ID is enabled/disabled</summary>
	public void SetTabEnabled(FName TabNameID,bool bEnable) {}
	///<summary>Sets whether the tab associated with the given ID is interactable</summary>
	public void SetTabInteractionEnabled(FName TabNameID,bool bEnable) {}
	///<summary>Disables the tab associated with the given ID with a reason</summary>
	public void DisableTabWithReason(FName TabNameID,FText Reason) {}
	///<summary>SetListeningForInput</summary>
	public virtual void SetListeningForInput(bool bShouldListen) {}
	///<summary>Returns the tab button matching the ID, if found</summary>
	public UCommonButtonBase GetTabButtonBaseByID(FName TabNameID) { return default; }
	///<summary>HandlePreLinkedSwitcherChanged_BP</summary>
	public void HandlePreLinkedSwitcherChanged_BP() {}
	///<summary>HandlePostLinkedSwitcherChanged_BP</summary>
	public void HandlePostLinkedSwitcherChanged_BP() {}
	///<summary>HandleTabCreation</summary>
	public void HandleTabCreation(FName TabNameID,UCommonButtonBase TabButton) {}
	///<summary>HandleTabRemoval</summary>
	public void HandleTabRemoval(FName TabNameID,UCommonButtonBase TabButton) {}
	///<summary>The input action to listen for causing the next tab to be selected</summary>
	public FDataTableRowHandle NextTabInputActionData;
	///<summary>The input action to listen for causing the previous tab to be selected</summary>
	public FDataTableRowHandle PreviousTabInputActionData;
	///<summary>The input action to listen for causing the next tab to be selected</summary>
	public UInputAction NextTabEnhancedInputAction;
	///<summary>The input action to listen for causing the previous tab to be selected</summary>
	public UInputAction PreviousTabEnhancedInputAction;
	///<summary>Whether to register to handle tab list input immediately upon construction</summary>
	public bool bAutoListenForInput;
	///<summary>Whether to defer until next tick rebuilding tab list when inserting new tab (rather than adding to the end).</summary>
	public bool bDeferRebuildingTabList;
	///<summary>HandleTabButtonSelected</summary>
	public void HandleTabButtonSelected(UCommonButtonBase SelectedTabButton,int ButtonIndex) {}
	///<summary>HandlePreviousTabInputAction</summary>
	public void HandlePreviousTabInputAction(bool bPassthrough) {}
	///<summary>HandleNextTabInputAction</summary>
	public void HandleNextTabInputAction(bool bPassthrough) {}
	///<summary>The activatable widget switcher that this tab list is associated with and manipulates</summary>
	public TWeakObjectPtr<UCommonAnimatedSwitcher> LinkedSwitcher;
	///<summary>The button group that manages all the created tab buttons</summary>
	public UCommonButtonGroupBase TabButtonGroup;
	///<summary>Info about each of the currently registered tabs organized by a given registration name ID</summary>
	public TMap<FName,FCommonRegisteredTabInfo> RegisteredTabsByID;
}
