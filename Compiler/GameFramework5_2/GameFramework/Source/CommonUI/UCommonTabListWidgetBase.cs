#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonTabListWidgetBase.h")]
///<summary>Base class for a list of selectable tabs that correspondingly activate and display an arbitrary widget in a linked switcher</summary>
public partial class UCommonTabListWidgetBase : UCommonUserWidget {
// CommonTabListWidgetBase
	public void FOnTabSelected(string TabId) {}
	public FOnTabSelected OnTabSelected;
	public void FOnTabButtonCreation(string TabId,UObject TabButton) {}
	public FOnTabButtonCreation OnTabButtonCreation;
	public void FOnTabButtonRemoval(string TabId,UObject TabButton) {}
	public FOnTabButtonRemoval OnTabButtonRemoval;
	public void FOnTabListRebuilt() {}
	public FOnTabListRebuilt OnTabListRebuilt;
	public string GetActiveTab() { return default; }
	public void SetLinkedSwitcher(UObject CommonSwitcher) {}
	public UObject GetLinkedSwitcher() { return default; }
	public bool RegisterTab(string TabNameID,UClass ButtonWidgetType,UObject ContentWidget,int TabIndex/*=-1*/) { return default; }
	public bool RemoveTab(string TabNameID) { return default; }
	public void RemoveAllTabs() {}
	public int GetTabCount() { return default; }
	public bool SelectTabByID(string TabNameID,bool bSuppressClickFeedback/*=false*/) { return default; }
	public string GetSelectedTabId() { return default; }
	public string GetTabIdAtIndex(int Index) { return default; }
	public void SetTabVisibility(string TabNameID,ESlateVisibility NewVisibility) {}
	public void SetTabEnabled(string TabNameID,bool bEnable) {}
	public void SetTabInteractionEnabled(string TabNameID,bool bEnable) {}
	public void DisableTabWithReason(string TabNameID,string Reason) {}
	public void SetListeningForInput(bool bShouldListen) {}
	public UObject GetTabButtonBaseByID(string TabNameID) { return default; }
	public void HandlePreLinkedSwitcherChanged_BP() {}
	public void HandlePostLinkedSwitcherChanged_BP() {}
	public void HandleTabCreation(string TabNameID,UObject TabButton) {}
	public void HandleTabRemoval(string TabNameID,UObject TabButton) {}
	public FDataTableRowHandle NextTabInputActionData;
	public FDataTableRowHandle PreviousTabInputActionData;
	public UInputAction NextTabEnhancedInputAction;
	public UInputAction PreviousTabEnhancedInputAction;
	public bool bAutoListenForInput;
	public bool bDeferRebuildingTabList;
	public void HandleTabButtonSelected(UObject SelectedTabButton,int ButtonIndex) {}
	public void HandlePreviousTabInputAction(bool bPassthrough) {}
	public void HandleNextTabInputAction(bool bPassthrough) {}
	public TWeakObjectPtr<UCommonAnimatedSwitcher> LinkedSwitcher;
	public UCommonButtonGroupBase TabButtonGroup;
	public TMap<string,FCommonRegisteredTabInfo> RegisteredTabsByID;
}
