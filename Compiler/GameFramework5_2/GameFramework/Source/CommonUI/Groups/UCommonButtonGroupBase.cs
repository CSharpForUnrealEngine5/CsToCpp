#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Groups/CommonButtonGroupBase.h")]
///<summary>Manages an arbitrary collection of CommonButton widgets.</summary>
public partial class UCommonButtonGroupBase : UCommonWidgetGroupBase {
// CommonButtonGroupBase
	public void SetSelectionRequired(bool bRequireSelection) {}
	public void DeselectAll() {}
	public void SelectNextButton(bool bAllowWrap/*=true*/) {}
	public void SelectPreviousButton(bool bAllowWrap/*=true*/) {}
	public void SelectButtonAtIndex(int ButtonIndex,bool bAllowSound/*=true*/) {}
	public int GetSelectedButtonIndex() { return default; }
	public int GetHoveredButtonIndex() { return default; }
	public int FindButtonIndex(UObject ButtonToFind) { return default; }
	public FSimpleButtonBaseGroupDelegate OnSelectedButtonBaseChanged;
	public FSimpleButtonBaseGroupDelegate OnHoveredButtonBaseChanged;
	public FSimpleButtonBaseGroupDelegate OnButtonBaseClicked;
	public FSimpleButtonBaseGroupDelegate OnButtonBaseDoubleClicked;
	public FOnSelectionCleared OnSelectionCleared;
	public UObject GetButtonBaseAtIndex(int Index) { return default; }
	public UObject GetSelectedButtonBase() { return default; }
	public bool HasAnyButtons() { return default; }
	public int GetButtonCount() { return default; }
	public bool bSelectionRequired;
	public void OnSelectionStateChangedBase(UObject BaseButton,bool bIsSelected) {}
	public void OnHandleButtonBaseClicked(UObject BaseButton) {}
	public void OnHandleButtonBaseDoubleClicked(UObject BaseButton) {}
	public void OnButtonBaseHovered(UObject BaseButton) {}
	public void OnButtonBaseUnhovered(UObject BaseButton) {}
}
