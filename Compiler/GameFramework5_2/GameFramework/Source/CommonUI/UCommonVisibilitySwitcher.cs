namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Basic switcher that toggles visibility on its children to only show one widget at a time. Activates visible widget if possible.</summary>
[CppInclude("CommonVisibilitySwitcher.h")]
public partial class UCommonVisibilitySwitcher : UOverlay {
	public static UClass StaticClass() {return default;}
	///<summary>SetActiveWidgetIndex</summary>
	public void SetActiveWidgetIndex(int Index) {}
	///<summary>GetActiveWidgetIndex</summary>
	public int GetActiveWidgetIndex() { return default; }
	///<summary>GetActiveWidget</summary>
	public UWidget GetActiveWidget() { return default; }
	///<summary>SetActiveWidget</summary>
	public void SetActiveWidget(UWidget Widget) {}
	///<summary>IncrementActiveWidgetIndex</summary>
	public void IncrementActiveWidgetIndex(bool bAllowWrapping/*=true*/) {}
	///<summary>DecrementActiveWidgetIndex</summary>
	public void DecrementActiveWidgetIndex(bool bAllowWrapping/*=true*/) {}
	///<summary>ActivateVisibleSlot</summary>
	public void ActivateVisibleSlot() {}
	///<summary>DeactivateVisibleSlot</summary>
	public void DeactivateVisibleSlot() {}
	///<summary>ShownVisibility</summary>
	public ESlateVisibility ShownVisibility;
	///<summary>ActiveWidgetIndex</summary>
	public int ActiveWidgetIndex;
	///<summary>Whether or not to automatically activate a slot when it becomes visible</summary>
	public bool bAutoActivateSlot;
	///<summary>Whether or not to activate the first slot if one is added dynamically</summary>
	public bool bActivateFirstSlotOnAdding;
}
