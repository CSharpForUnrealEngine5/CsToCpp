#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonVisibilitySwitcher.h")]
///<summary>Basic switcher that toggles visibility on its children to only show one widget at a time. Activates visible widget if possible.</summary>
public partial class UCommonVisibilitySwitcher : UOverlay {
// CommonVisibilitySwitcher
	public void SetActiveWidgetIndex(int Index) {}
	public int GetActiveWidgetIndex() { return default; }
	public UObject GetActiveWidget() { return default; }
	public void SetActiveWidget(UObject Widget) {}
	public void IncrementActiveWidgetIndex(bool bAllowWrapping/*=true*/) {}
	public void DecrementActiveWidgetIndex(bool bAllowWrapping/*=true*/) {}
	public void ActivateVisibleSlot() {}
	public void DeactivateVisibleSlot() {}
	public ESlateVisibility ShownVisibility;
	public int ActiveWidgetIndex;
	public bool bAutoActivateSlot;
	public bool bActivateFirstSlotOnAdding;
}
